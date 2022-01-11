using FluentAPIDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPIDemo
{
    internal class EsameConfiguration : IEntityTypeConfiguration<Esame>
    {
        public void Configure(EntityTypeBuilder<Esame> builder)
        {
            //ENTITA' ESAME
            builder.ToTable("Esame");
            builder.Property(e => e.EsameID).HasColumnOrder(0).HasColumnName("Esame ID");
            builder.Property(e => e.Nome).HasMaxLength(30).IsRequired();

            builder.HasOne(e => e.Studente).WithMany(s => s.Esami).HasForeignKey(s => s.StudentID).HasConstraintName("Fk_Studente");

        }
    }
}