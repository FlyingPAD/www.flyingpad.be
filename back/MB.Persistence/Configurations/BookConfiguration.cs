using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(entity => entity.EntityId); // Définir la clé primaire

            builder.Property(entity => entity.EntityId)
                .ValueGeneratedOnAdd(); // Indiquer que la valeur est générée lors de l'ajout (auto-increment)
        }
    }
}
