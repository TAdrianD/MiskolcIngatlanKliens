using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiskolcIngatlanKliens.Models
{
    internal class Ingatlan
    {
        public int Id { get; set; }
        public string Telepules { get; set; } = null!;
        public string Cim { get; set; } = null!;
        public int Ar { get; set; }
        public string Tipus { get; set; } = null!;
        public string KepNev { get; set; } = null!;
        public int UgyintezoId { get; set; }
        public virtual Ugyintezo? Ugyintezo { get; set; } = null!;
    }
}
