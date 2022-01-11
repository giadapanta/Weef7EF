using CarFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFluentAPI
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            
            builder.ToTable("Car");
            builder.Property(e => e.Plate).HasColumnOrder(0).HasColumnName("Plate Car");
            builder.Property(e => e.Places).IsRequired();
            builder.Property(e => e.CodiceFiscale).IsFixedLength(true).HasMaxLength(16);


            builder.HasOne(p =>p.Owner).WithMany(c => c.Cars).HasForeignKey(p => p.CodiceFiscale).HasConstraintName("Fk_Person");
        }
    }
}