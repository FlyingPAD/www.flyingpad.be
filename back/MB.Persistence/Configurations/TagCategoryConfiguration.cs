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

        builder.HasData(
            new TagCategory { EntityId = 1, BusinessId = Guid.Parse("3f1b2d5a-7e89-4c11-a2f3-1d4b6c7e8f90"), Name = "#" },
            new TagCategory { EntityId = 2, BusinessId = Guid.Parse("b4c3d2e1-5f6a-4b7c-8d9e-0a1b2c3d4e5f"), Name = "# File" },
            new TagCategory { EntityId = 3, BusinessId = Guid.Parse("0dda8c71-8f2a-4c99-94b1-9adf3e2c5a7b"), Name = "# File ext. | Audio" },
            new TagCategory { EntityId = 4, BusinessId = Guid.Parse("a1b2c3d4-e5f6-7890-ab12-cd34ef56ab79"), Name = "# File ext. | Image" },
            new TagCategory { EntityId = 5, BusinessId = Guid.Parse("11223344-5566-7788-99aa-bbccddeeff11"), Name = "# File ext. | Video" },
            new TagCategory { EntityId = 6, BusinessId = Guid.Parse("22334455-6677-8899-aabb-ccddeeff2233"), Name = "# File Format" }
        );
    }
}