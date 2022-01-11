using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNotationCar.Models
{
    public class Person
    {
       [Key]
       public string CodiceFiscale { get; set; }
        public string FirstName { get; set; }    

        public string LastName { get; set; }    
        public DateTime DateOfBirth { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>();
        public override string ToString()
        {
            return $"{CodiceFiscale} - {FirstName} {LastName} - {DateOfBirth}";
        }

    }
}
