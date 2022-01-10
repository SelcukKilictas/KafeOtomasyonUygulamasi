using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class KafeBilgi:CafeBase
    {
        public byte Logo { get; set; }
        public string Ad { get; set; }
        public List<Kat> Katlar { get; set; } = new List<Kat>();

    }
}
