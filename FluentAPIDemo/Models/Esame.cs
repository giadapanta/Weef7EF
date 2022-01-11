using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo.Models
{
    public class Esame
    {
        public int EsameID { get; set; }
        public string Nome { get; set; }
        public int? CFU { get; set; }

        public int? Votazione { get; set; }
        public bool Passato { get; set; }
        public int StudentID { get; set; }
        //nav property
        public Studente Studente { get; set; }

    }
}
