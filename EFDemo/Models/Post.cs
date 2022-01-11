using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Models
{
    public class Post
    {
        public int Id { get; set; } //oppure ID o PostID
        public string Text { get; set; }    
        public DateTime Date { get; set; }  

        //devo collegare le due cose 
        public Blog Blog { get; set; }  //navigation property
        public int BlogId { get; set; } //foreign key con convenzione. 

    }
}
