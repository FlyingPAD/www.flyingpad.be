using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.StyleAggregate;

namespace MB.Persistence.Configurations;

public class StyleConfiguration : IEntityTypeConfiguration<Style>
{
    public void Configure(EntityTypeBuilder<Style> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
