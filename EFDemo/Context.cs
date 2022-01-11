using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    public class Context : DbContext //deve ereditare dal dbcontext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        //costruttore 
        public Context() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //stringa di connessione -> il percorso dove creare il db 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AcademyABlogPost;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

    }
}
