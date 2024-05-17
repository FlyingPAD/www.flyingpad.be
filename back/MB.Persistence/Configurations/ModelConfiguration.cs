using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.HasKey(entity => entity.EntityId); // Définir la clé primaire

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd(); // Indiquer que la valeur est générée lors de l'ajout (auto-increment)

        builder.Property(entity => entity.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(entity => entity.LastName)
            .HasMaxLength(50);
    }
}
