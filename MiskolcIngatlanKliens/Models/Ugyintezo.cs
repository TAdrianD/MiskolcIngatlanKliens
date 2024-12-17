using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiskolcIngatlanKliens.Models
{
    internal class Ugyintezo
    {
        public int Id { get; set; }
        public string Nev { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Email { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<Ingatlan> Ingatlans { get; set; } = new List<Ingatlan>();
    }
}
