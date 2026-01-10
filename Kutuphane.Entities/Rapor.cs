using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class Rapor
    {

    }
    public class EnCokKitapAlanDto
    {
        public string AdSoyad { get; set; }
        public int KitapSayisi { get; set; }

        public EnCokKitapAlanDto()
        {
            AdSoyad = "";
            KitapSayisi = 0;
        }
    }

  

    public class RaporOzetDto
    {
        public int ToplamOdunc { get; set; }
        public int BuAyOdunc { get; set; }

        public bool EnCokKitapAlanVar { get; set; }
        public EnCokKitapAlanDto EnCokKitapAlan { get; set; }

        public bool EnGecKalanVar { get; set; }
        public EnGecKalanKitapDto EnGecKalan { get; set; }

        public RaporOzetDto()
        {
            EnCokKitapAlan = new EnCokKitapAlanDto();
            EnGecKalan = new EnGecKalanKitapDto();
            EnCokKitapAlanVar = false;
            EnGecKalanVar = false;
        }
        public class OduncDetayDto
        {
            public int OduncId { get; set; }
            public string KitapAdi { get; set; }
            public string UyeAdiSoyadi { get; set; }
            public DateTime OduncTarihi { get; set; }
            public DateTime? TeslimTarihi { get; set; }
            public int GecikmeGun { get; set; }
        }
        public class EnCokKitapAlanDto2
        {
            public int UyeId { get; set; }
            public string UyeAdiSoyadi { get; set; }
            public int AldigiKitapSayisi { get; set; }
        }

    }
}

