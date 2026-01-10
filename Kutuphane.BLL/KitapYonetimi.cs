using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DAL;
using Kutuphane.Entities;

namespace Kutuphane.BLL
{
    public class KitapYonetimi
    {
        private readonly KitapDAL _kitapDal;
        public KitapYonetimi()
        {
            _kitapDal = new KitapDAL();
           
        }
        public List<Kitap> KitapAra(string kitapAdi) //çalışıyor
        {
            if (string.IsNullOrWhiteSpace(kitapAdi))
            {
                return new List<Kitap>();
            }
            return _kitapDal.KitapAra(kitapAdi.Trim());
        }
        public DataTable KitapAra2(string q) => _kitapDal.KitapAra2(q);
        public List<Kitap> TumKitaplariGetir()
        {
            return _kitapDal.TumKitaplariGetir();
        }
        public bool KitapEkleStoklu(Kitap kitap, out string mesaj)
        {
            if(string.IsNullOrWhiteSpace(kitap.KitapAdi))
            {
                mesaj = "Kitap adı boş olamaz.";
                return false;
            }
            if(string.IsNullOrWhiteSpace(kitap.Isbn))
            {
                mesaj = "ISBN boş olamaz.";
                return false;
            }
            int sonuc = _kitapDal.KitapEkleVeyaStokArttir(kitap);
            if ( sonuc > 0)
            {
                mesaj = "Kitap eklendi / stok güncellendi.";
                return true;
            }

            mesaj = "Kitap eklenemedi.";
            return false;
        }
        public bool KitapGuncelle(Kitap kitap, string eskiIsbn,string eskiBaski, out string mesaj)
        {
            if (kitap.Id <= 0)
            {
                mesaj = "Güncellenecek kitabı seçmediniz.";
                return false;
            }
            int sonuc = _kitapDal.KitapGuncelle(kitap, eskiIsbn, eskiBaski);
            if (sonuc > 0)
            {
                mesaj = "Kitap/Stok bilgisi güncellendi.";
                return true;
            }
            mesaj = "Kitap güncellenemedi";
            return false;
        }
        public bool KitapSil(int id, string isbn, string baski, out string mesaj, out int kalanStok)
        {
            kalanStok = -1;
            if (id <= 0)
            {
                mesaj = "Silinecek kitabı seçmediniz.";
                return false;
            }
            int sonuc = _kitapDal.KitapSil(id, isbn, baski, out kalanStok);
            if(sonuc > 0)           
                mesaj = $"Stok 1 azaltıldı. Kalan stok: {kalanStok} adet.";
            else
                mesaj = "Bu baskıya ait tüm stoklar tükendi, kitap veritabanından silindi.";
            return true;

            mesaj = "ISBN veya baskı bilgisi hatalı, silme işlemi yapılmadı.";
            return false;
        }
        public DataTable MevcutKitaplariGetir()
        {
            return _kitapDal.MevcutKitaplariGetir();
        }
    }
}
