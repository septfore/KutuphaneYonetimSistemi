using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string YayinEvi { get; set; }
        public int BasimYili { get; set; }
        public int StokAdedi { get; set; }
        public string Turu { get; set; } 
        public bool OduncDurumu { get; set; }
        public string OduncDurumText
        {
            get
            {
                return OduncDurumu ? "Ödünç Alınmış" : "Mevcut";
            }
        }
        public string Baski { get; set; }
        public string Isbn { get; set; }
    }
}
