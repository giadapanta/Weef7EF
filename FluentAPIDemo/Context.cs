using FluentAPIDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIDemo
{
    internal class Context: DbContext

    {
        public DbSet<Studente> Studenti { get; set; }
        public DbSet<Esame> Esami { get; set; }

        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //stringa di connessione -> il percorso dove creare il db 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RegistroEsami;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        //per usare fluent api 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////ENTITA' ESAME
            //modelBuilder.Entity<Esame>(e => e.ToTable("Esame"));
            //modelBuilder.Entity<Esame>(e => e.Property(e => e.EsameID).HasColumnOrder(0).HasColumnName("Esame ID"));
            //modelBuilder.Entity<Esame>(e => e.Property(e => e.Nome).HasMaxLength(30).IsRequired());


            ////def della relazione stud esame 1:n
            //modelBuilder.Entity<Esame>(e => e.HasOne(e => e.Studente).WithMany(s => s.Esami).HasForeignKey(s => s.StudentID).HasConstraintName("Fk_Studente"));

            ////ENTITà STUDENTE
            //modelBuilder.Entity<Studente>(e => e.ToTable("Studente"));
            //modelBuilder.Entity<Studente>(e => e.HasKey(e => e.StudentID));
            //modelBuilder.Entity<Studente>(e => e.Property(e => e.Cognome).IsRequired());
            //modelBuilder.Entity<Studente>(e => e.Property(e => e.Nome).IsRequired());

            ////relazione studente esame 1:n
            //modelBuilder.Entity<Studente>(e => e.HasMany(s => s.Esami).WithOne(e => e.Studente).HasForeignKey(e => e.EsameID).HasConstraintName("Fk_Esame"));

            //nb. è meglio avereuna riga per ogni entità e poi le altre cose le rimandiamo in
            //un'altra classe, perchè è troppo lungo.

            modelBuilder.ApplyConfiguration<Esame>(new EsameConfiguration());
            modelBuilder.ApplyConfiguration<Studente>(new StudentConfiguration());



        }


    }
}
