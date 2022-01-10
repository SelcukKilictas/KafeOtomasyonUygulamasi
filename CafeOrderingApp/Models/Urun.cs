using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class Urun:CafeBase
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public byte[] Fotograf { get; set; }
        public override string ToString()
        {
            return $"{Ad} - {Fiyat:c2}";
        }

    }
}
