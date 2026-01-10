using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KulNo { get; set; }
        public string KulAdi { get; set; }    
        public string KulSoyadi { get; set; }
        public string TelNo { get; set; }
        public string Eposta { get; set; }
        public DateTime UyelikTarihi { get; set; }
        public string Sifre { get; set; }
       public string Rol { get; set; }
    }
}
