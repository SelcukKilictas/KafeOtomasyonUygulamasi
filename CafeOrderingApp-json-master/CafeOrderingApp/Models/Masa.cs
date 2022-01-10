using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class Masa:CafeBase
    {
        public string Ad { get; set; }
        public int Sira { get; set; }
        public MasaDurumlar MasaDurumu { get; set; }
        public override string ToString() => $"{Sira} - {Ad}";
        
    }
}
