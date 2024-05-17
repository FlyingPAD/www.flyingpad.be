using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration;

public class StyleConfiguration : IEntityTypeConfiguration<Style>
{
    public void Configure(EntityTypeBuilder<Style> builder)
    {
        builder.HasKey(entity => entity.EntityId); // Définir la clé primaire

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd(); // Indiquer que la valeur est générée lors de l'ajout (auto-increment)

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
