using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configurations;

public class LinkConfiguration : IEntityTypeConfiguration<Link>
{
    public void Configure(EntityTypeBuilder<Link> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
