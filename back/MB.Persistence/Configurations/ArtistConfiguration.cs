using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(entity => entity.EntityId);          // Primary Key

            builder.Property(entity => entity.EntityId)
                .ValueGeneratedOnAdd();                         // Auto Increment

            builder.Property(entity => entity.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}