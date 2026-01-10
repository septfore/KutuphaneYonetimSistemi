using Kutuphane.DAL;
using Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kutuphane.Entities.EnCokKitapAlanDto;
using static Kutuphane.Entities.RaporOzetDto;

namespace Kutuphane.BLL
{
    public class GunlukOduncDto
    {
        public DateTime Tarih { get; set; }
        public int OduncSayisi { get; set; }
    }
   
    public class RaporYonetimi
    {

        RaporDAL raporDal = new RaporDAL();       
        public DataTable EnCokOduncAlinan5Kitap()
        {
            return raporDal.GetEnCokOduncAlinan5Kitap();
        }
        public DataTable EnCokGeciken5Odunc()
        {
            return raporDal.GetEnCokGeciken5Odunc();
        }
        public DataTable EnAktif5Uye()
        {
            return raporDal.GetEnAktif5Uye();
        }
        public int BuAyVerilenKitapSayisiGetir()
        {
            return raporDal.GetBuAyVerilenKitapSayisi();
        }
        public List<GunlukOduncDto> GunlukOduncSerisi(DateTime baslangic, DateTime bitis)
        {
            DataTable dt = raporDal.GetGunlukOduncSayilari(baslangic, bitis);

            var map = new Dictionary<DateTime, int>();
            foreach (DataRow row in dt.Rows)
            {
                DateTime t = Convert.ToDateTime(row["Tarih"]).Date;
                int sayi = Convert.ToInt32(row["OduncSayisi"]); // COUNT bigint -> güvenli
                map[t] = sayi;
            }

            var list = new List<GunlukOduncDto>();
            for (var d = baslangic.Date; d <= bitis.Date; d = d.AddDays(1))
            {
                list.Add(new GunlukOduncDto
                {
                    Tarih = d,
                    OduncSayisi = map.TryGetValue(d, out int v) ? v : 0
                });
            }

            return list;
        }
        public RaporOzetDto GetRaporOzeti()
        {
            
            var dto = new RaporOzetDto();

            dto.ToplamOdunc = raporDal.GetToplamOdunc();
            dto.BuAyOdunc = raporDal.GetBuAyOdunc();

            bool v1;
            dto.EnCokKitapAlan = raporDal.GetEnCokKitapAlan(out v1);
            dto.EnCokKitapAlanVar = v1;

            bool v2;
            dto.EnGecKalan = raporDal.GetEnGecKalanKitap(out v2);
            dto.EnGecKalanVar = v2;

            return dto;
        }
        public List<EnCokKitapAlanUyeDto> EnCokKitapAlanUyeleriGetir()
        {
            return raporDal.EnCokKitapAlanUyeleriGetir();
        }
        public List<EnGecKalanKitapDto> EnGecKalanKitaplariGetir()
        {
            return raporDal.EnGecKalanKitaplariGetir();
        }
    }
}
