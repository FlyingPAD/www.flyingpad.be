using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.TagCategoryAggregate;

namespace MB.Persistence.Configurations;

public class TagCategoryConfiguration : IEntityTypeConfiguration<TagCategory>
{
    public void Configure(EntityTypeBuilder<TagCategory> builder)
    {
        builder.HasKey(tc => tc.EntityId);

        builder.Property(tc => tc.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(tc => tc.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(tc => tc.Tags)
               .WithOne(t => t.TagCategory)
               .HasForeignKey(t => t.TagCategoryId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}