using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo.Models
{
    public class Studente
    {
        public int StudentID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime? DataNascita { get; set; }

        public ICollection<Esame> Esami { get; set; } = new List<Esame>();  
    }
}
