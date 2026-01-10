using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string KulAd { get; set; }
        public string KulSoyad { get; set; }
        public string TelNo { get; set; }
        public string EPosta { get; set; }
        public DateTime KayitTarihi { get; set; } 
        public string Sifre { get; set; }  
        public string Rol { get; set; }

    }
}
