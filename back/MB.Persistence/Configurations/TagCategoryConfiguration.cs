using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration
{
    public class TagCategoryConfiguration : IEntityTypeConfiguration<TagCategory>
    {
        public void Configure(EntityTypeBuilder<TagCategory> builder)
        {
            builder.HasKey(tc => tc.EntityId); // Définir la clé primaire

            builder.Property(tc => tc.EntityId)
                .ValueGeneratedOnAdd(); // Indiquer que la valeur est générée lors de l'ajout

            builder.Property(tc => tc.Name)
                .IsRequired()
                .HasMaxLength(50); // Assurer que le nom est requis et définir une longueur maximale

            // Configuration de la relation TagCategory -> Tags
            builder.HasMany(tc => tc.Tags) // Propriété de navigation dans TagCategory
                   .WithOne(t => t.TagCategory) // La propriété de navigation inverse dans Tag
                   .HasForeignKey(t => t.TagCategoryId) // Clé étrangère dans Tag
                   .OnDelete(DeleteBehavior.Restrict); // Choisissez le comportement de suppression approprié
        }
    }
}