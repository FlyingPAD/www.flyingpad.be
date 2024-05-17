using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        // Définir la clé primaire

        builder.HasKey(tag => tag.EntityId);

        // Configuration de la génération automatique de l'ID

        builder.Property(tag => tag.EntityId).ValueGeneratedOnAdd();

        // Configuration des propriétés

        builder.Property(tag => tag.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(tag => tag.Description)
            .HasMaxLength(200);

        // Configuration de la relation Tag -> TagCategory

        builder.HasOne(tag => tag.TagCategory)
               .WithMany(tc => tc.Tags)                     // Utiliser la propriété de collection de Tags dans TagCategory
               .HasForeignKey(tag => tag.TagCategoryId)
               .OnDelete(DeleteBehavior.Restrict);          // Choisissez le comportement de suppression approprié
    }

    // Optionnel: Configurez ici d'autres relations si Tag est impliqué dans d'autres relations
    // Optionnel: Ajoutez des index ou d'autres configurations spécifiques à l'entité
}