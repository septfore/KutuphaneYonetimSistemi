using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class EnCokKitapAlanUyeDto
    {
        public int KullaniciId { get; set; }
        public string KulNo { get; set; }
        public string AdSoyad { get; set; }
        public string Rol { get; set; }
        public int AlinanKitapSayisi { get; set; }
    }
}
