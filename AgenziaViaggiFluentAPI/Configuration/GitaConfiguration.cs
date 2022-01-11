using AgenziaViaggi2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggiFluentAPI
{
    internal class GitaConfiguration : IEntityTypeConfiguration<Gita>
    {
        public void Configure(EntityTypeBuilder<Gita> builder)
        {
            builder.HasOne(e => e.Itinerari).WithMany(s => s.Gite).HasForeignKey(s => s.ItinerarioID).HasConstraintName("Fk_Itinerario");
            builder.HasOne(e => e.Responsabili).WithMany(s => s.Gite).HasForeignKey(s => s.ResponsabileID).HasConstraintName("Fk_Responsabile");
            builder.HasMany(e => e.Partecipanti).WithMany(s => s.Gite);
        }
    }
}