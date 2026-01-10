using Kutuphane.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DAL
{
    public class KullaniciDAL
    {


        private readonly string _baglanti = "Server=172.21.54.253;Database=26_132430048;Uid=26_132430048;Pwd=İnif123.;";
        public Kullanici GirisYap(string kulNo, string sifre)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "SELECT * FROM Kullanicilar WHERE kulNo = @kulNo AND sifre = @Sifre";

                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kulNo", kulNo);
                    komut.Parameters.AddWithValue("@Sifre", sifre);
                    using (var oku = komut.ExecuteReader())
                    {
                        if (oku.Read())
                        {
                            return new Kullanici
                            {
                                Id = Convert.ToInt32(oku["Id"]),
                                KulAdi = oku["kulAdi"].ToString(),
                                KulNo = oku["kulNo"].ToString(),
                                Rol = oku["Rol"].ToString()
                            };

                        }
                    }
                }
            }

            return null; // eşleşme yoksa
        }
        public DataTable KullaniciAra(string q)
        {
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT Id, kulNo, kulAdi, kulSoyad, telNo, ePosta
            FROM Kullanicilar
            WHERE (@q = '' OR kulNo LIKE CONCAT('%', @q, '%'))
            ORDER BY kulNo
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
        public DataTable UyeleriGetir()
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "SELECT Id, kulNo, kulAdi, kulSoyad, CONCAT(kulAdi, ' ', kulSoyad) AS AdSoyad, telNo, ePosta, uyelikTarihi, Sifre, Rol FROM Kullanicilar WHERE rol = 'Uye';";             
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }                 
            }
        }
        public DataTable KulAraNo(string kulNo)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "SELECT Id, kulNo, kulAdi, kulSoyad, telNo, ePosta, uyelikTarihi, Sifre, Rol FROM Kullanicilar WHERE rol = 'Uye' AND kulNo LIKE @kulNo";               
                    
                    using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@kulNo", "%" + kulNo + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }              
            }
        }
        public int UyeEkle(Kullanici uye)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "INSERT INTO Kullanicilar (kulNo, kulAdi, kulSoyad, telNo, ePosta, uyelikTarihi, Sifre, Rol) " +
                               "VALUES (@kulNo, @kulAdi, @kulSoyad, @telNo, @ePosta, @uyelikTarihi, @Sifre, 'Uye')";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kulNo", uye.KulNo);
                    komut.Parameters.AddWithValue("@kulAdi", uye.KulAdi);
                    komut.Parameters.AddWithValue("@kulSoyad", uye.KulSoyadi);
                    komut.Parameters.AddWithValue("@telNo", uye.TelNo);
                    komut.Parameters.AddWithValue("@ePosta", uye.Eposta);
                    komut.Parameters.AddWithValue("@uyelikTarihi", uye.UyelikTarihi);
                    komut.Parameters.AddWithValue("@Sifre", uye.Sifre);
                    return komut.ExecuteNonQuery();
                }
            }
        }
        public int UyeGuncelle(Kullanici uye)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "UPDATE Kullanicilar SET kulNo = @kulNo, kulAdi = @kulAdi, kulSoyad = @kulSoyad, " +
                               "telNo = @telNo, ePosta = @ePosta, uyelikTarihi = @uyelikTarihi, Sifre = @Sifre " +
                               "WHERE Id = @Id AND rol = 'Uye'";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kulNo", uye.KulNo);
                    komut.Parameters.AddWithValue("@kulAdi", uye.KulAdi);
                    komut.Parameters.AddWithValue("@kulSoyad", uye.KulSoyadi);
                    komut.Parameters.AddWithValue("@telNo", uye.TelNo);
                    komut.Parameters.AddWithValue("@ePosta", uye.Eposta);
                    komut.Parameters.AddWithValue("@uyelikTarihi", uye.UyelikTarihi);
                    komut.Parameters.AddWithValue("@Sifre", uye.Sifre);
                    komut.Parameters.AddWithValue("@Id", uye.Id);
                    return komut.ExecuteNonQuery();
                }
            }
        }
        public int UyeSil(int id)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "DELETE FROM Kullanicilar WHERE Id = @Id AND rol = 'Uye'";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@Id", id);
                    return komut.ExecuteNonQuery();
                }
            }

        }
        public DataTable UyeleriOduncIcinGetir()
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "SELECT Id, kulNo, kulAdi, kulSoyad, CONCAT(kulAdi, ' ', kulSoyad) AS AdSoyad, telNo, ePosta FROM Kullanicilar WHERE rol = 'Uye';";
                using (var adapter = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DateTime? GetCezaBitisTarihi(int kullaniciId)
        {
            using (var baglanti = DatabaseHelper.GetConnection())
            {
                string sorgu = "SELECT CezaBitisTarihi FROM Kullanicilar WHERE Id = @Id";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@Id", kullaniciId);
                    object sonuc = komut.ExecuteScalar();
                    if(sonuc == null|| sonuc == DBNull.Value)
                    {
                        return null;
                    }
                    return Convert.ToDateTime(sonuc);
                }
            }
        }
    }
}    
