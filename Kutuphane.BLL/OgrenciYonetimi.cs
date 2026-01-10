using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DAL;
using Kutuphane.Entities;

namespace Kutuphane.BLL
{
    public class OgrenciYonetimi
    {
        private readonly KullaniciDAL _kullaniciDal = new KullaniciDAL();
        public DataTable KullaniciAra(string q) => _kullaniciDal.KullaniciAra(q);
        public DataTable UyeleriGetir()
        {
            return _kullaniciDal.UyeleriGetir();
        }
        public DataTable KulNoAra(string kulNo)
        {
            if(string.IsNullOrWhiteSpace(kulNo))
                return _kullaniciDal.UyeleriGetir();
            return _kullaniciDal.KulAraNo(kulNo);
        }
        public bool UyeEkle(Kullanici uye, out string mesaj)
        {
           if(string.IsNullOrWhiteSpace(uye.KulNo) || string.IsNullOrWhiteSpace(uye.KulAdi) || string.IsNullOrWhiteSpace(uye.KulSoyadi) || string.IsNullOrWhiteSpace(uye.Sifre))
            {
                mesaj = "Kullanıcı Numarası, Adı, Soyadı ve Şifre boş olamaz!";
                return false;
            }
            try
            {
                int s = _kullaniciDal.UyeEkle(uye);
                mesaj = s > 0 ? "Üye eklendi." : "Üye eklenemedi.";
                return s > 0;
            }
            catch(MySqlException ex) when (ex.Number == 1062)
            {
                string m = ex.Message.ToLower();

                if (m.Contains("uq_kulno"))
                    mesaj = "Bu kullanıcı numarası zaten kayıtlı.";
                else if (m.Contains("uq_eposta"))
                    mesaj = "Bu e-posta ile zaten kayıt var.";
                else if (m.Contains("uq_telno"))
                    mesaj = "Bu telefon numarası ile zaten kayıt var.";
                else
                    mesaj = "Aynı bilgilere sahip bir kayıt zaten var.";

                return false;
            }
        }
        public bool UyeGuncelle(Kullanici uye, out string mesaj)
        {
            if(uye.Id <= 0)
            {
                mesaj = "Lütfen tablodan bir üye seçin.";
                return false;
            }
            int s = _kullaniciDal.UyeGuncelle(uye);
            mesaj = s > 0 ? "Üye güncellendi." : "Güncelleme başarısız.";
            return s > 0;
        }
        public bool UyeSil(int id, out string mesaj)
        {
            if(id <= 0)
            {
                mesaj = "Lütfen tablodan bir üye seçin.";
                return false;
            }
            int s = _kullaniciDal.UyeSil(id);
            mesaj = s > 0 ? "Üye silindi." : "Silme işlemi başarısız.";
            return s > 0;
        }
        
        public DataTable UyeleriOduncIcinGetir()
        {
            return _kullaniciDal.UyeleriOduncIcinGetir();
        }
    }
}

