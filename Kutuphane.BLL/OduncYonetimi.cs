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
    public class OduncYonetimi
    {
        private OduncDAL oduncDal = new OduncDAL();
        private KullaniciDAL kullaniciDal = new KullaniciDAL();
        public OduncYonetimi()
        {
          
        }
        public DataTable EnCokAlinanKitapDetayGetir()
        { 
            return oduncDal.EnCokAlinanKitapDetayGetir();
        }
        public bool OduncVer(int kullaniciId, int kitapId, DateTime oduncTarihi, out string mesaj)
        {
            mesaj = "";
           if(kullaniciId <= 0)
           {
               mesaj = "Lütfen listeden bir üye seçin.";
               return false;
           }
           if(kitapId <= 0)
           {
               mesaj = "Lütfen listeden bir kitap seçin.";
               return false;
           }
            DateTime bugun = DateTime.Now.Date;
            DateTime? cezaBitis = kullaniciDal.GetCezaBitisTarihi(kullaniciId);
            if(cezaBitis.HasValue && cezaBitis.Value.Date > bugun)
            {
                mesaj = "Bu kullanıcının " + cezaBitis.Value.ToShortDateString() + " tarihine kadar devam eden bir cezası var. Yeni ödünç verilemez.";
                return false;
            }
            int aktifOduncSayisi = oduncDal.GetAktifOduncSayisi(kullaniciId);
            if(aktifOduncSayisi >= 3)
            {
                mesaj = "Bu kullanıcı zaten 3 kitap ödünç almış. Yeni ödünç verilemez.";
                return false;
            }
            bool basarili = oduncDal.OduncVer(kullaniciId, kitapId, oduncTarihi);
            if (!basarili)
            {
                mesaj = "Bu kitaptan şu anda stok yok. Ödünç Verilemedi.";
                return false;
            }
            mesaj = "Kitap başarıyla ödünç verildi. Teslim tarihi : " + oduncTarihi.AddDays(15).ToShortDateString();
            return true;
        }
        public DataTable TumAktifOduncleriGetir()
        {
            return oduncDal.GetTumAktifOduncler();
        }
        public bool IadeAl(int oduncId, DateTime iadeTarihi, out string mesaj, out int gecikmeGun)
        {
            mesaj = "";
            gecikmeGun = 0;
            if(oduncId <= 0)
            {
                mesaj = "Lütfen listeden iade edilecek kitabı seçin.";
                return false;
            }
            bool basarili = oduncDal.IadeAl(oduncId, iadeTarihi, out gecikmeGun);
            if (!basarili)
            {
                mesaj = "İade işlemi gerçekletirilemedi. Kayıt bulunamadı veya zaten iade alınmış.";
                return false;
            }
            if(gecikmeGun > 0)
            {
                mesaj = "İade işlemi başarıyla gerçekleştirildi. Kitap " + gecikmeGun + " gün gecikmeli iade edildi.";
            }
            else
            {
                mesaj = "İade işlemi başarıyla gerçekleştirildi.";
            }
            return true;
        }
    }
}
