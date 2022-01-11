using FluentAPIDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPIDemo
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Studente>
    {
        public void Configure(EntityTypeBuilder<Studente> builder)
        {
            //ENTITà STUDENTE
            builder.ToTable("Studente");
           builder.HasKey(e => e.StudentID);
         builder.Property(e => e.Cognome).IsRequired();
            builder.Property(e => e.Nome).IsRequired();

            //relazione studente esame 1:n
            builder.HasMany(s => s.Esami).WithOne(e => e.Studente).HasForeignKey(e => e.EsameID).HasConstraintName("Fk_Esame");
        }
    }
}