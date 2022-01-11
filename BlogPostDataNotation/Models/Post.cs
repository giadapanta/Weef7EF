using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostDataNotation.Models
{
    public class Post
    {
        public int Id { get; set; } //oppure ID o PostID
        public string Text { get; set; }    
        public DateTime Date { get; set; }

        //devo collegare le due cose 
        [ForeignKey(nameof(BlogUrl))]
        public Blog Blog { get; set; }  //navigation property

        public string BlogUrl { get; set; } //foreign key con convenzione. 

        
    }
}
