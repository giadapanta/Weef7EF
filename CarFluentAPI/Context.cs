using CarFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFluentAPI
{
    internal class Context : DbContext 
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> People { get; set; }
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //stringa di connessione -> il percorso dove creare il db 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarFluentAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration<Car>(new CarConfiguration());
            modelBuilder.ApplyConfiguration<Person>(new PersonConfiguration());



        }
    }
}
