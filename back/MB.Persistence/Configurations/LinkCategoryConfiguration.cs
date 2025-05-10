using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.LinkCategoryAggregate;

namespace MB.Persistence.Configurations;

public class LinkCategoryConfiguration : IEntityTypeConfiguration<LinkCategory>
{
    public void Configure(EntityTypeBuilder<LinkCategory> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}