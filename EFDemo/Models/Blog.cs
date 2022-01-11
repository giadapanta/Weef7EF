using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Models
{
    public  class Blog
    {
        public int BlogId { get; set; } 
        public string Name { get; set; }    
        public string Author { get; set; } 

      //devo aggiungere la collection di post
      public ICollection<Post> Posts { get; set; } =new List<Post>();

        public override string ToString()
        {
            return $"{BlogId} - {Name} - {Author}";
        }
    }
}
