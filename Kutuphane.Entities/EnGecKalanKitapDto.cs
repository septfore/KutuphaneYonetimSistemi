using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class EnGecKalanKitapDto
   {
        public int OduncId { get; set; }
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string Isbn { get; set; }

        public int KullaniciId { get; set; }
        public string KulNo { get; set; }
        public string UyeAdSoyad { get; set; }

        public System.DateTime OduncTarihi { get; set; }
        public System.DateTime TeslimTarihiPlanlanan { get; set; }
        public System.DateTime? TeslimTarihiGercek { get; set; }

        public int GecikmeGun { get; set; }
        public string Durum { get; set; }
    }
}
