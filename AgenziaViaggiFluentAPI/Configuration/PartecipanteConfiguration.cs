using AgenziaViaggi2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggiFluentAPI
{
    internal class PartecipanteConfiguration : IEntityTypeConfiguration<Partecipante>
    {
        public void Configure(EntityTypeBuilder<Partecipante> builder)
        {
            builder.HasMany(e => e.Gite).WithMany(s => s.Partecipanti);
        }
    }
}