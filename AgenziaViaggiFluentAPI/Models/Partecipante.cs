using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi2.Models
{
    public class Partecipante
    {
        public int PartecipanteID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string Indirizzo { get; set; }
        public string Città { get; set; }
        public int GitaID { get; set; }
        public ICollection<Gita> Gite { get; set; }=new List<Gita>();
    }
}
