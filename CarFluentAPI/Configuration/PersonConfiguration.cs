using CarFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarFluentAPI
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            
            builder.ToTable("People");
            builder.HasKey(e => e.CodiceFiscale);
            builder.Property(e => e.FirstName).IsRequired();
            builder.Property(e => e.LastName).IsRequired();
            builder.Property(e => e.CodiceFiscale).IsFixedLength(true).HasMaxLength(16);

            
            builder.HasMany(s => s.Cars).WithOne(e => e.Owner).HasForeignKey(e => e.Plate).HasConstraintName("Fk_Car");
        }
    }

    }
