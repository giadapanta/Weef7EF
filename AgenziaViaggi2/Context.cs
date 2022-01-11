﻿using AgenziaViaggi2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi2
{
    public class Context : DbContext 
    {
        public DbSet<Gita> Gite { get; set; }
        public DbSet<Partecipante> Partecipanti { get; set;}
        public DbSet<Responsabile> Responsabili { get; set; }
        public DbSet<Itinerario> Itinerari { get; set;}
        public Context() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //stringa di connessione -> il percorso dove creare il db 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgenziaViaggi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
    }
}
