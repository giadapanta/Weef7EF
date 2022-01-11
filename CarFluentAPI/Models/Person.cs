using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFluentAPI.Models
{
    public class Person
    {
        [Key]
        public string CodiceFiscale { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
