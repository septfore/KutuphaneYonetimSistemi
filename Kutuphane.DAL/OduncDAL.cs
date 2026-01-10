using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Kutuphane.Entities;

namespace Kutuphane.DAL
{
    public class OduncDAL
    {
       public bool OduncVer(int kullaniciId, int kitapId, DateTime oduncTarihi)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                using (var tran = baglanti.BeginTransaction())
                {
                    //stok kontrolü
                    int stokAdedi;
                    using(var stokKomut = new MySqlCommand("SELECT StokAdedi FROM Kitaplar WHERE Id=@KitapId FOR UPDATE", baglanti, tran))
                    {
                        stokKomut.Parameters.AddWithValue("@KitapId", kitapId);
                        var sonuc = stokKomut.ExecuteScalar(); 
                        if (sonuc == null)
                           throw new Exception("Kitap bulunamadı.");
                        stokAdedi = Convert.ToInt32(sonuc);
                        if(stokAdedi <= 0)
                        {
                            throw new Exception("Kitap stokta yok.");
                            return false;
                        }
                    }

                    //OduncIslemlere ekle
                    using (var oduncKomut = new MySqlCommand(@"INSERT INTO OduncIslemleri (KullaniciId, KitapId, OduncTarihi, TeslimTarihiPlanlanan, Durum) VALUES (@kulId, @kitapId, @oduncTarihi, @teslimPlan, 'OduncVerildi')",baglanti, tran))
                    {
                        oduncKomut.Parameters.AddWithValue("@kulId", kullaniciId);
                        oduncKomut.Parameters.AddWithValue("@kitapId", kitapId);
                        oduncKomut.Parameters.AddWithValue("@oduncTarihi", oduncTarihi);
                        oduncKomut.Parameters.AddWithValue("@teslimPlan", oduncTarihi.AddDays(15));
                        oduncKomut.ExecuteNonQuery();
                    }

                    //stok azalt
                    using(var stokGuncelle = new MySqlCommand("UPDATE Kitaplar SET StokAdedi = StokAdedi - 1 WHERE Id=@KitapId", baglanti, tran))
                    {
                        stokGuncelle.Parameters.AddWithValue("@KitapId", kitapId);
                        stokGuncelle.ExecuteNonQuery();
                    }
                    tran.Commit();
                    return true;
                }
            }
        }

        public int GetAktifOduncSayisi(int kullaniciId)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "SELECT COUNT(*) FROM OduncIslemleri WHERE KullaniciId=@kulId AND TeslimTarihiGercek IS NULL";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kulId", kullaniciId);
                    object sonuc = komut.ExecuteScalar();
                    return Convert.ToInt32(sonuc);
                }
            }
        }
        public DataTable GetTumAktifOduncler()
        {
            using(var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = @"
    SELECT 
        oi.Id AS OduncId,
        k.Id AS KitapId,
        u.Id AS KullaniciId,
        k.Isbn,
        k.KitapAdi,
        k.YayinEvi,
        k.Baski,
        u.kulNo,
        CONCAT(u.kulAdi, ' ', u.kulSoyad) AS AdSoyad,
        u.telNo,
        u.ePosta,
        oi.OduncTarihi,
        oi.TeslimTarihiPlanlanan,
        GREATEST(DATEDIFF(CURDATE(), oi.TeslimTarihiPlanlanan), 0) AS GecikmeGun,
        CASE 
            WHEN CURDATE() > oi.TeslimTarihiPlanlanan THEN 1
            ELSE 0
        END AS Gecikmis
    FROM OduncIslemleri oi
    JOIN Kitaplar k ON oi.KitapId = k.Id
    JOIN Kullanicilar u ON oi.KullaniciId = u.Id
    WHERE oi.Durum = 'OduncVerildi'    
    ORDER BY Gecikmis DESC, oi.TeslimTarihiPlanlanan ASC;
        ";
                using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public bool IadeAl(int oduncId, DateTime iadeTarihi, out int gecikmeGun)
        {
            gecikmeGun = 0;
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                using (var tran = baglanti.BeginTransaction())
                {
                    int kitapId;
                    DateTime teslimPlanlanan;
                    using (var secKomut = new MySqlCommand("SELECT KitapId, TeslimTarihiPlanlanan FROM OduncIslemleri WHERE Id=@OduncId AND Durum = 'OduncVerildi'", baglanti, tran))
                    {
                        secKomut.Parameters.AddWithValue("@OduncId", oduncId);
                        using (var reader = secKomut.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                tran.Rollback();
                                return false;
                            }
                            kitapId = Convert.ToInt32(reader["KitapId"]);
                            teslimPlanlanan = Convert.ToDateTime(reader["TeslimTarihiPlanlanan"]);
                        }
                    }
                    int fark = (iadeTarihi.Date - teslimPlanlanan.Date).Days;
                    gecikmeGun = fark > 0 ? fark : 0;
                   
                    using(var guncelle = new MySqlCommand(@"UPDATE OduncIslemleri SET TeslimTarihiGercek=@iadeTarihi, Durum = 'IadeAlindi' WHERE Id=@OduncId", baglanti, tran))
                    {
                        guncelle.Parameters.AddWithValue("@iadeTarihi", iadeTarihi);
                        guncelle.Parameters.AddWithValue("@OduncId", oduncId);
                        guncelle.ExecuteNonQuery();
                    }
                    using (var stokGuncelle = new MySqlCommand(@"UPDATE Kitaplar SET StokAdedi = StokAdedi + 1 WHERE Id = @kitapId", baglanti, tran))
                    {
                        stokGuncelle.Parameters.AddWithValue("@kitapId", kitapId);
                        stokGuncelle.ExecuteNonQuery();
                    }
                    tran.Commit();
                    return true;
                }
            }
        }
        public DataTable EnCokAlinanKitapDetayGetir()
        {
            string sorgu = @" SELECT k.Id, k.KitapAdi, k.Isbn, k.YayinEvi, k.Baski, k.StokAdedi, k.Turu, COUNT(oi.Id) AS AlinmaSayisi
                            FROM Kitaplar k
                            LEFT JOIN OduncIslemleri oi ON oi.KitapId = k.Id
                            GROUP BY k.Id, k.KitapAdi, k.Isbn, k.YayinEvi, k.Baski, k.StokAdedi, k.Turu
                            ORDER BY AlinmaSayisi DESC, k.KitapAdi ASC;";

            var dt = new DataTable();

            using (var conn = DatabaseHelper.GetConnection()) // sende nasılsa aynı bırak
            using (var cmd = new MySqlCommand(sorgu, conn))
            using (var adp = new MySqlDataAdapter(cmd))
            {
                adp.Fill(dt);
            }

            return dt;
        }
    }
}