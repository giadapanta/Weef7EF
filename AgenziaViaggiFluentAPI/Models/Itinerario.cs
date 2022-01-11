using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi2.Models
{
    public class Itinerario
    {
        public int ItinerarioID { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double Durata { get; set; }
        public ICollection<Gita> Gite { get; set; }= new List<Gita>();

    }
}
