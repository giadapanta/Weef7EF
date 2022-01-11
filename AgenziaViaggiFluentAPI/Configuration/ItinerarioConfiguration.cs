using AgenziaViaggi2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggiFluentAPI
{
    internal class ItinerarioConfiguration : IEntityTypeConfiguration<Itinerario>
    {
        public void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            builder.HasMany(e => e.Gite).WithOne(s => s.Itinerari).HasForeignKey(s => s.GitaID).HasConstraintName("Fk_Gita");
        }
    }
}