using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class Siparis:CafeBase
    {
        public Urun Urun { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public Masa Masa { get; set; }
        public decimal AraToplam { get => Adet * Fiyat; }
    }
}
