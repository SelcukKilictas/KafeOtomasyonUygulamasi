using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class Kategori:CafeBase
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public byte[] Fotograf { get; set; }
        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public override string ToString()
        {
            return Ad;
        }
    }
}
