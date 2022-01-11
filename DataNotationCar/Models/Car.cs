using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNotationCar.Models
{
    public class Car
    {
        [Key]
        public string Plate { get; set; }   

        public int Places { get; set; } 
        public string Brand { get; set; }
        public DateTime DateOfRegistration { get; set; }

        [ForeignKey(nameof(CodiceFiscale))]
        public Person Owner { get; set; }
        public string CodiceFiscale { get; set; }

      public override string ToString()
        {
            return $"{Plate} - n°: {Places} - {Brand} - {DateOfRegistration}";
        }

    }
}
