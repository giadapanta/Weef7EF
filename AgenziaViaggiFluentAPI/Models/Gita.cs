using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi2.Models
{
    public class Gita
    {
        public int GitaID { get; set; }
        public DateTime DataPartenza { get; set; }
        public int PartecipanteID { get; set; }
        public ICollection<Partecipante> Partecipanti { get; set; } = new List<Partecipante>();

        public int ItinerarioID { get; set; }
        public int ResponsabileID { get; set; }
        public Itinerario Itinerari { get; set; }
        public Responsabile Responsabili { get; set; }
        
    }
}
