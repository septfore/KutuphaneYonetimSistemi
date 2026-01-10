using Kutuphane.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Kutuphane.DAL
{
    public class KitapDAL
    {
        public List<Kitap> KitapAra(string kitapAdi) //çalışıyor
        {
            List<Kitap> kitaplar = new List<Kitap>();
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                //baglanti.Open();
                string sorgu = @"SELECT Id, KitapAdi, Yazar, Yayinevi, Isbn, BasimYili, Baski, StokAdedi, Turu, OduncDurumu FROM Kitaplar WHERE KitapAdi LIKE @KitapAdi";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@KitapAdi", "%" + kitapAdi + "%");
                    using (var oku = komut.ExecuteReader())
                    {
                        while (oku.Read())
                        {
                            Kitap k = new Kitap
                            {
                                Id = oku.GetInt32("Id"),
                                KitapAdi = oku.GetString("KitapAdi"),
                                Yazar = oku.IsDBNull(oku.GetOrdinal("Yazar")) ? "" : oku.GetString("Yazar"),
                                YayinEvi = oku.IsDBNull(oku.GetOrdinal("YayinEvi")) ? "" : oku.GetString("YayinEvi"),
                                Isbn = oku.IsDBNull(oku.GetOrdinal("ISBN")) ? "" : oku.GetString("ISBN"),
                                BasimYili = oku.IsDBNull(oku.GetOrdinal("BasimYili")) ? 0 : oku.GetInt32("BasimYili"),
                                Baski = oku.IsDBNull(oku.GetOrdinal("Baski")) ? "" : oku.GetString("Baski"),
                                StokAdedi = oku.IsDBNull(oku.GetOrdinal("StokAdedi")) ? 0 : oku.GetInt32("StokAdedi"),
                                Turu = oku.IsDBNull(oku.GetOrdinal("Turu")) ? "" : oku.GetString("Turu"),
                                OduncDurumu = oku.GetBoolean("OduncDurumu")
                            };
                          kitaplar.Add(k);
                        }
                    }
                }
            }
            return kitaplar;
        }
        public DataTable KitapAra2(string q)
        {
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT Id, KitapAdi, Yazar, YayinEvi, Baski
            FROM Kitaplar
            WHERE (@q = '' OR KitapAdi LIKE CONCAT('%', @q, '%'))
            ORDER BY KitapAdi
            LIMIT 200;";

                cmd.Parameters.AddWithValue("@q", q ?? "");

                using (var da = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public List<Kitap> TumKitaplariGetir() //çalışıyor
        {
                List<Kitap> kitaplar = new List<Kitap>();
                using (var baglanti = DatabaseHelper.GetConnection())
                {
                      string sorgu = "SELECT Id, KitapAdi, Yazar, Yayinevi, Isbn, BasimYili, Baski, StokAdedi, Turu, CASE WHEN StokAdedi > 0 THEN false ELSE true END AS OduncDurumu FROM Kitaplar ORDER BY KitapAdi ASC, Baski ASC";
                      using (var komut = new MySqlCommand(sorgu, baglanti))
                      {
                          using (var oku = komut.ExecuteReader())
                          {
                             while (oku.Read())
                             {
                                Kitap k = new Kitap
                                {
                                Id = oku.GetInt32("Id"),
                                KitapAdi = oku.GetString("KitapAdi"),
                                Yazar = oku.IsDBNull(oku.GetOrdinal("Yazar")) ? "" : oku.GetString("Yazar"),
                                YayinEvi = oku.IsDBNull(oku.GetOrdinal("YayinEvi")) ? "" : oku.GetString("YayinEvi"),
                                Isbn = oku.IsDBNull(oku.GetOrdinal("ISBN")) ? "" : oku.GetString("ISBN"),
                                BasimYili = oku.IsDBNull(oku.GetOrdinal("BasimYili")) ? 0 : oku.GetInt32("BasimYili"),
                                Baski = oku.IsDBNull(oku.GetOrdinal("Baski")) ? ""   : oku.GetString("Baski"),
                                StokAdedi = oku.IsDBNull(oku.GetOrdinal("StokAdedi")) ? 0 : oku.GetInt32("StokAdedi"),
                                Turu = oku.IsDBNull(oku.GetOrdinal("Turu")) ? "" : oku.GetString("Turu"),
                                OduncDurumu = oku.GetBoolean("OduncDurumu")
                                };
                               kitaplar.Add(k);
                             }
                          }
                      }
                }
                return kitaplar;
        }
        public int KitapEkleVeyaStokArttir(Kitap kitap)
        {
            using (MySqlConnection baglanti = DatabaseHelper.GetConnection())
            {
                string kontrolSorgu = "SELECT Id, StokAdedi FROM Kitaplar WHERE Isbn = @Isbn AND Baski = @Baski LIMIT 1";
                using (var kontrolKomut = new MySqlCommand(kontrolSorgu, baglanti))
                {
                    kontrolKomut.Parameters.AddWithValue("@Isbn", kitap.Isbn);
                    kontrolKomut.Parameters.AddWithValue("@Baski", kitap.Baski);
                    using (var oku = kontrolKomut.ExecuteReader())
                    {
                        if(oku.Read())
                        {
                            int mevcutId = oku.GetInt32("Id"); //VARSA stok arttır
                            oku.Close();

                            string guncelleSorgu = "UPDATE Kitaplar SET StokAdedi = StokAdedi + 1 WHERE Id = @Id";

                            using(var guncelleKomut = new MySqlCommand(guncelleSorgu,baglanti))
                            {
                                guncelleKomut.Parameters.AddWithValue("Id", mevcutId);
                                return guncelleKomut.ExecuteNonQuery(); 
                            }
                        }
                    }
                }
                // YOKSA → yeni satır ekle, StokAdedi = 1, OduncDurumu = 0 (Mevcut)
                string ekleSorgu =
                    "INSERT INTO Kitaplar " +
                    "(KitapAdi, Yazar, YayinEvi, Isbn, BasimYili, Baski, StokAdedi, Turu, OduncDurumu) " +
                    "VALUES " +
                    "(@KitapAdi, @Yazar, @YayinEvi, @Isbn, @BasimYili, @Baski, @StokAdedi, @Turu, @OduncDurumu)";

                using (var ekleKomut = new MySqlCommand(ekleSorgu, baglanti))
                {
                    ekleKomut.Parameters.AddWithValue("@KitapAdi", kitap.KitapAdi);
                    ekleKomut.Parameters.AddWithValue("@Yazar", kitap.Yazar);
                    ekleKomut.Parameters.AddWithValue("@YayinEvi", kitap.YayinEvi);
                    ekleKomut.Parameters.AddWithValue("@Isbn", kitap.Isbn);
                    ekleKomut.Parameters.AddWithValue("@BasimYili", kitap.BasimYili);
                    ekleKomut.Parameters.AddWithValue("@Baski", kitap.Baski);
                    ekleKomut.Parameters.AddWithValue("@StokAdedi", 1);           // 👈 ilk stok = 1
                    ekleKomut.Parameters.AddWithValue("@Turu", kitap.Turu);
                    ekleKomut.Parameters.AddWithValue("@OduncDurumu", false);     // 👈 yeni kitaplar mevcut

                    return ekleKomut.ExecuteNonQuery();
                }
            }          
        }
        
        public int KitapGuncelle(Kitap yeniKitap, string eskiIsbn, string eskiBaski)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {              
                string stokSorgu = @"SELECT StokAdedi FROM Kitaplar WHERE Isbn = @EskiIsbn AND Baski = @EskiBaski LIMIT 1";
                int stokAdedi = 0;
                using(var stokKomut = new MySqlCommand(stokSorgu, baglanti))
                {
                    stokKomut.Parameters.AddWithValue("Id", yeniKitap.Id);
                    stokKomut.Parameters.AddWithValue("@EskiIsbn", eskiIsbn);
                    stokKomut.Parameters.AddWithValue("@EskiBaski", eskiBaski);
                    using (var oku = stokKomut.ExecuteReader())
                    {
                        if (!oku.Read())
                            return 0;
                        stokAdedi = oku.GetInt32("StokAdedi");
                    }
                }
                if(eskiIsbn == yeniKitap.Isbn && eskiBaski == yeniKitap.Baski)
                {
                    //ISBN ve Baskı değişmemiş, direkt güncelle
                    string sorgu = @"UPDATE Kitaplar SET KitapAdi = @KitapAdi, Yazar = @Yazar, YayinEvi = @YayinEvi, Isbn = @Isbn, BasimYili = @BasimYili, Baski = @Baski, StokAdedi = @StokAdedi, Turu = @Turu WHERE Id = @Id";
                    using (var komut = new MySqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@KitapAdi", yeniKitap.KitapAdi);
                        komut.Parameters.AddWithValue("@Yazar", yeniKitap.Yazar);
                        komut.Parameters.AddWithValue("@YayinEvi", yeniKitap.YayinEvi);
                        komut.Parameters.AddWithValue("@Isbn", yeniKitap.Isbn);
                        komut.Parameters.AddWithValue("@BasimYili", yeniKitap.BasimYili);
                        komut.Parameters.AddWithValue("@Baski", yeniKitap.Baski);
                        komut.Parameters.AddWithValue("@StokAdedi", stokAdedi); //mevcut stok
                        komut.Parameters.AddWithValue("@Turu", yeniKitap.Turu);
                        komut.Parameters.AddWithValue("@Id", yeniKitap.Id);
                        return komut.ExecuteNonQuery();
                    }
                }
                if (stokAdedi > 1)
                {
                    string eskiGuncelleSorgu = @"UPDATE Kitaplar SET StokAdedi = StokAdedi - 1 WHERE Id = @Id";
                    using (var eskiKomut = new MySqlCommand(eskiGuncelleSorgu, baglanti))
                    {
                        eskiKomut.Parameters.AddWithValue("@Id", yeniKitap.Id);
                        eskiKomut.ExecuteNonQuery();
                    }
                }
                else
                {
                    string eskiSilSorgu = @"DELETE FROM Kitaplar WHERE Id = @Id";
                    using (var eskiSilKomut = new MySqlCommand(eskiSilSorgu, baglanti))
                    {
                        eskiSilKomut.Parameters.AddWithValue("@Id", yeniKitap.Id);
                        eskiSilKomut.ExecuteNonQuery();
                    }   
                }
                string kontrolSorgu = "SELECT Id, StokAdedi FROM Kitaplar WHERE Isbn = @Isbn AND Baski = @Baski LIMIT 1";
                int varId = 0;
                int varStok = 0;
                using (var kontrolKomut = new MySqlCommand(kontrolSorgu, baglanti))
                {
                    kontrolKomut.Parameters.AddWithValue("@Isbn", yeniKitap.Isbn);
                    kontrolKomut.Parameters.AddWithValue("@Baski", yeniKitap.Baski);
                    using (var oku = kontrolKomut.ExecuteReader())
                    {
                        if (oku.Read())
                        {
                            varId = oku.GetInt32("Id");
                            varStok = oku.GetInt32("StokAdedi");
                        }
                    }
                }
                if(varId > 0)
                {
                    string yeniGuncelleSorgu = @"UPDATE Kitaplar SET StokAdedi = StokAdedi + 1 WHERE Id = @Id";
                    using(var yeniKomut = new MySqlCommand(yeniGuncelleSorgu, baglanti))
                    {
                        yeniKomut.Parameters.AddWithValue("@Id", varId);
                        return yeniKomut.ExecuteNonQuery();
                    }
                }
                else
                {
                    string yeniEkleSorgu =
                    "INSERT INTO Kitaplar " +
                    "(KitapAdi, Yazar, YayinEvi, Isbn, BasimYili, Baski, StokAdedi, Turu, OduncDurumu) " +
                    "VALUES " +
                    "(@KitapAdi, @Yazar, @YayinEvi, @Isbn, @BasimYili, @Baski, 1, @Turu, 0)";
                    using (var yeniEkleKomut = new MySqlCommand(yeniEkleSorgu, baglanti))
                    {
                        yeniEkleKomut.Parameters.AddWithValue("@KitapAdi", yeniKitap.KitapAdi);
                        yeniEkleKomut.Parameters.AddWithValue("@Yazar", yeniKitap.Yazar);
                        yeniEkleKomut.Parameters.AddWithValue("@YayinEvi", yeniKitap.YayinEvi);
                        yeniEkleKomut.Parameters.AddWithValue("@Isbn", yeniKitap.Isbn);
                        yeniEkleKomut.Parameters.AddWithValue("@BasimYili", yeniKitap.BasimYili);
                        yeniEkleKomut.Parameters.AddWithValue("@Baski", yeniKitap.Baski);
                        yeniEkleKomut.Parameters.AddWithValue("@StokAdedi", 1);           // 👈 ilk stok = 1
                        yeniEkleKomut.Parameters.AddWithValue("@Turu", yeniKitap.Turu);
                        yeniEkleKomut.Parameters.AddWithValue("@OduncDurumu", false);     // 👈 yeni kitaplar mevcut
                        return yeniEkleKomut.ExecuteNonQuery();
                    }
                }
            }
        }

        public int KitapSil(int id, string isbn, string baski, out int yeniStok)
        {
            yeniStok = -1; //default
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string stokSorgu = @"SELECT StokAdedi FROM Kitaplar WHERE Id = @Id AND Isbn = @Isbn AND Baski = @Baski LIMIT 1";
                int stokAdedi = 0;
                using (var stokKomut = new MySqlCommand(stokSorgu, baglanti))
                {
                    stokKomut.Parameters.AddWithValue("@Id", id);
                    stokKomut.Parameters.AddWithValue("@Isbn", isbn);
                    stokKomut.Parameters.AddWithValue("@Baski", baski);
                    using (var oku = stokKomut.ExecuteReader())
                    {
                        if (oku.Read())
                        {
                            stokAdedi = oku.GetInt32("StokAdedi");
                        }
                        else
                        {
                            return 0; // Kitap bulunamadı
                        }
                    }
                }
                if (stokAdedi > 1)
                {
                    string guncelleSorgu = @"UPDATE Kitaplar SET StokAdedi = StokAdedi - 1 WHERE Id = @Id AND Isbn = @Isbn AND Baski = @Baski";
                    using (var guncelleKomut = new MySqlCommand(guncelleSorgu, baglanti))
                    {
                        guncelleKomut.Parameters.AddWithValue("@Id", id);
                        guncelleKomut.Parameters.AddWithValue("@Isbn", isbn);
                        guncelleKomut.Parameters.AddWithValue("@Baski", baski);
                        int sonuc = guncelleKomut.ExecuteNonQuery();
                        if (sonuc > 0)
                            yeniStok = stokAdedi - 1; //kalan stok
                        return sonuc;
                    }
                }
                else
                {
                    string silSorgu = @"DELETE FROM Kitaplar WHERE Id = @Id AND Isbn = @Isbn AND Baski = @Baski";
                    using (var silKomut = new MySqlCommand(silSorgu, baglanti))
                    {
                        silKomut.Parameters.AddWithValue("@Id", id);
                        silKomut.Parameters.AddWithValue("@Isbn", isbn);
                        silKomut.Parameters.AddWithValue("@Baski", baski);
                        int sonuc = silKomut.ExecuteNonQuery();
                        if (sonuc > 0)
                            yeniStok = 0; //stok bitti
                        return sonuc;
                    }
                }
            }
        }
        public DataTable MevcutKitaplariGetir()
        {
            using(var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "SELECT Id, KitapAdi, Yazar, YayinEvi, Isbn, BasimYili, Baski, StokAdedi, CASE WHEN StokAdedi > 0 THEN 'Mevcut' ELSE 'Ödünçte' END AS OduncDurumu FROM Kitaplar WHERE StokAdedi>0;";
                using(var adapter = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
                                
    }      
}