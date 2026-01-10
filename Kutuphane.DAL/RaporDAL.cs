using Kutuphane.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kutuphane.Entities.EnCokKitapAlanDto;
using static Kutuphane.Entities.RaporOzetDto;

namespace Kutuphane.DAL
{
    public class RaporDAL
    {
        private readonly string _cs;
        public DataTable GetEnCokOduncAlinan5Kitap()
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = @"SELECT 
                k.KitapAdi,
                COUNT(oi.Id) AS OduncSayisi
                FROM OduncIslemleri oi
                JOIN Kitaplar k ON oi.KitapId = k.Id
                GROUP BY k.Id
                ORDER BY OduncSayisi DESC
                LIMIT 5;";

                using (var da = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetEnCokGeciken5Odunc()
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = @"
            SELECT 
                oi.Id AS OduncId,
                k.KitapAdi,
                k.Isbn,
                u.kulNo,
                CONCAT(u.kulAdi, ' ', u.kulSoyad) AS AdSoyad,
                oi.TeslimTarihiPlanlanan,
                DATEDIFF(CURDATE(), oi.TeslimTarihiPlanlanan) AS GecikmeGun
            FROM OduncIslemleri oi
            JOIN Kitaplar k     ON oi.KitapId     = k.Id
            JOIN Kullanicilar u ON oi.KullaniciId = u.Id
            WHERE TRIM(oi.Durum) = 'OduncVerildi'
              AND oi.TeslimTarihiPlanlanan < CURDATE()
            ORDER BY GecikmeGun DESC
            LIMIT 5;
        ";

                using (var da = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetEnAktif5Uye()
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = @"
            SELECT 
                u.Id,
                u.kulNo,
                CONCAT(u.kulAdi, ' ', u.kulSoyad) AS AdSoyad,
                COUNT(oi.Id) AS OduncSayisi
            FROM OduncIslemleri oi
            JOIN Kullanicilar u ON oi.KullaniciId = u.Id
            GROUP BY u.Id
            ORDER BY OduncSayisi DESC
            LIMIT 5;
        ";

                using (var da = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public int GetBuAyVerilenKitapSayisi()
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = @"SELECT COUNT(*) AS BuAyOduncSayisi FROM OduncIslemleri WHERE OduncTarihi BETWEEN DATE_FORMAT(CURDATE(), '%Y-%m-01') AND LAST_DAY(CURDATE());";

                using (var komut = new MySqlCommand(sorgu, baglanti))
                {                     
                    object sonuc = komut.ExecuteScalar();

                    if (sonuc == null || sonuc == DBNull.Value)
                        return 0;

                    return Convert.ToInt32(sonuc);
                }
            }
        }
        public DataTable GetGunlukOduncSayilari(DateTime baslangic, DateTime bitis)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = @"
            SELECT DATE(OduncTarihi) AS Tarih,
                   COUNT(*)          AS OduncSayisi
            FROM OduncIslemleri
            WHERE OduncTarihi >= @baslangic
              AND OduncTarihi <  DATE_ADD(@bitis, INTERVAL 1 DAY)
            GROUP BY DATE(OduncTarihi)
            ORDER BY Tarih;";

                using (var da = new MySqlDataAdapter(sorgu, baglanti))
                {
                    da.SelectCommand.Parameters.AddWithValue("@baslangic", baslangic.Date);
                    da.SelectCommand.Parameters.AddWithValue("@bitis", bitis.Date);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            
        }
       
        public int GetToplamOdunc()
        {
            using (var con = DatabaseHelper.GetConnection())
            {                
                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM OduncIslemleri", con))
                {
                    return System.Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public int GetBuAyOdunc()
        {
            using (var con = DatabaseHelper.GetConnection())
            {
                using (var cmd = new MySqlCommand(@"
                    SELECT COUNT(*)
                    FROM OduncIslemleri
                    WHERE MONTH(oduncTarihi)=MONTH(CURDATE())
                      AND YEAR(oduncTarihi)=YEAR(CURDATE())", con))
                {
                    return System.Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public EnCokKitapAlanDto GetEnCokKitapAlan(out bool varMi)
        {
            varMi = false;

            using (var con = DatabaseHelper.GetConnection())
            {
                using (var cmd = new MySqlCommand(@"
                    SELECT CONCAT(k.kulAdi, ' ', k.kulSoyad) AS AdSoyad,
                           COUNT(o.Id) AS KitapSayisi
                    FROM OduncIslemleri o
                    JOIN Kullanicilar k ON o.KullaniciId = k.Id
                    GROUP BY o.KullaniciId
                    ORDER BY KitapSayisi DESC
                    LIMIT 1;", con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read()) return new EnCokKitapAlanDto();

                        varMi = true;
                        return new EnCokKitapAlanDto
                        {
                            AdSoyad = dr["adSoyad"].ToString(),
                            KitapSayisi = System.Convert.ToInt32(dr["kitapSayisi"])
                        };
                    }
                }
            }
        }
        public EnGecKalanKitapDto GetEnGecKalanKitap(out bool varMi)
        {
            varMi = false;

            using (var con = DatabaseHelper.GetConnection())
            {
                using (var cmd = new MySqlCommand(@"
                    SELECT kt.KitapAdi,
                           DATEDIFF(CURDATE(), o.TeslimTarihiPlanlanan) AS GecikmeGun
                    FROM OduncIslemleri o
                    JOIN Kitaplar kt ON o.KitapId = kt.Id
                    WHERE o.TeslimTarihiGercek IS NULL
                      AND o.Durum = 'OduncVerildi'
                      AND o.TeslimTarihiPlanlanan < CURDATE()
                    ORDER BY GecikmeGun DESC
                    LIMIT 1;", con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read()) return new EnGecKalanKitapDto();

                        varMi = true;
                        return new EnGecKalanKitapDto
                        {
                            KitapAdi = dr["kitapAdi"].ToString(),
                            GecikmeGun = System.Convert.ToInt32(dr["gecikmeGun"])
                        };
                    }
                }
            }
        }
        public List<EnCokKitapAlanUyeDto> EnCokKitapAlanUyeleriGetir()
        {
            var liste = new List<EnCokKitapAlanUyeDto>();
            string sorgu = @"SELECT k.Id AS KullaniciId, k.kulNo, CONCAT(k.kulAdi, ' ', k.kulSoyad) AS AdSoyad, k.Rol, COUNT(o.Id) AS AlinanKitapSayisi FROM Kullanicilar k LEFT JOIN OduncIslemleri o ON o.KullaniciId = k.Id WHERE k.Rol = 'Uye' GROUP BY k.Id, k.kulNo, k.kulAdi, k.kulSoyad, k.Rol ORDER BY AlinanKitapSayisi DESC, AdSoyad ASC";
            using(var baglanti = DatabaseHelper.GetConnection())
            using (var komut = new MySqlCommand(sorgu, baglanti))
            {
                using(var oku = komut.ExecuteReader())
                {
                    while(oku.Read())
                    {
                        liste.Add(new EnCokKitapAlanUyeDto
                        {
                            KullaniciId = oku.GetInt32("KullaniciId"),
                            KulNo = oku["kulNo"].ToString(),
                            AdSoyad = oku["AdSoyad"].ToString(),
                            Rol = oku["Rol"].ToString(),
                            AlinanKitapSayisi = oku.GetInt32("AlinanKitapSayisi")
                        });

                    }
                }
                return liste;
            }
        }
        public List<EnGecKalanKitapDto> EnGecKalanKitaplariGetir()
        {
            var liste = new List<EnGecKalanKitapDto>();
            string sorgu = @"SELECT o.Id AS OduncId, k.Id AS KitapId, k.KitapAdi, k.Isbn, u.Id AS KullaniciId, u.kulNo, CONCAT(u.KulAdi, ' ', u.kulSoyad) AS UyeAdSoyad, o.OduncTarihi, o.TeslimTarihiPlanlanan, o.TeslimTarihiGercek, DATEDIFF(IFNULL(o.TeslimTarihiGercek, CURDATE()), o.TeslimTarihiPlanlanan) AS GecikmeGun, o.Durum FROM OduncIslemleri o INNER JOIN Kitaplar k ON k.Id = o.KitapId INNER JOIN Kullanicilar u ON u.Id = o.KullaniciId WHERE u.Rol = 'Uye' AND DATEDIFF(IFNULL(o.TeslimTarihiGercek, CURDATE()), o.TeslimTarihiPlanlanan) > 0 ORDER BY GecikmeGun DESC, o.TeslimTarihiPlanlanan ASC;";
            using (var baglanti = DatabaseHelper.GetConnection())
            using (var komut = new MySqlCommand(sorgu, baglanti))
            {
                using (var oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {

                        DateTime? gercek = oku["TeslimTarihiGercek"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(oku["TeslimTarihiGercek"]);
                        liste.Add(new EnGecKalanKitapDto
                        {
                            OduncId = Convert.ToInt32(oku["OduncId"]),
                            KitapId = Convert.ToInt32(oku["KitapId"]),
                            KitapAdi = oku["KitapAdi"].ToString(),
                            Isbn = oku["Isbn"].ToString(),
                            KullaniciId = Convert.ToInt32(oku["KullaniciId"]),
                            KulNo = oku["kulNo"].ToString(),
                            UyeAdSoyad = oku["UyeAdSoyad"].ToString(),

                            OduncTarihi = Convert.ToDateTime(oku["OduncTarihi"]),
                            TeslimTarihiPlanlanan = Convert.ToDateTime(oku["TeslimTarihiPlanlanan"]),
                            TeslimTarihiGercek = gercek,

                            GecikmeGun = Convert.ToInt32(oku["GecikmeGun"]),
                            Durum = oku["Durum"].ToString()
                        });
                    }
                }
                return liste;

            }






        }

    }
}
