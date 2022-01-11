using AgenziaViaggi2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenziaViaggiFluentAPI
{
    internal class ResponsabileConfiguration : IEntityTypeConfiguration<Responsabile>
    {
        public void Configure(EntityTypeBuilder<Responsabile> builder)
        {
            builder.HasMany(e => e.Gite).WithOne(s => s.Responsabili).HasForeignKey(s => s.GitaID).HasConstraintName("Fk_Responsabile");
        }
    }
}