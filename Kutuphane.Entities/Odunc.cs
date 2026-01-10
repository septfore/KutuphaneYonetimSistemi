using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class Odunc
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public int KitapId { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime IadeTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }

    }
}
