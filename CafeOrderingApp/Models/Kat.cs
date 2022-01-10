using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class Kat:CafeBase
    {
        public string Ad { get; set; }
        public int Sira { get; set; }
        public string Kod { get; set; }
        public List<Masa> Masalar { get; set; } = new List<Masa>();
        public override string ToString() => $"{Ad} - {Masalar.Count}";
        
    }
}
