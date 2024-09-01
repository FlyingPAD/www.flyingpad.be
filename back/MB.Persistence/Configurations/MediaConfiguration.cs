using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration;

public class MediaConfiguration : IEntityTypeConfiguration<Media>
{
    public void Configure(EntityTypeBuilder<Media> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
