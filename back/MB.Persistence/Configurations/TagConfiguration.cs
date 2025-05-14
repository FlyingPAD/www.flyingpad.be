using MB.Domain.TagAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(tag => tag.EntityId);
        builder.Property(tag => tag.EntityId).ValueGeneratedOnAdd();

        builder.Property(tag => tag.BusinessId)
            .IsRequired();

        builder.HasIndex(tag => tag.BusinessId)
            .HasDatabaseName("IX_Tag_BusinessId");

        builder.Property(tag => tag.Name)
            .IsRequired()
            .HasMaxLength(30)
            .HasColumnType("VARCHAR(30)");

        builder.Property(tag => tag.Description)
            .HasMaxLength(150)
            .HasColumnType("VARCHAR(150)");

        builder.HasOne(tag => tag.TagCategory)
            .WithMany(tc => tc.Tags)
            .HasForeignKey(tag => tag.TagCategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(tag => tag.TagCategoryId)
            .HasDatabaseName("IX_Tag_TagCategoryId");

        builder.HasData(
            new Tag { EntityId = 1, BusinessId = Guid.Parse("3f1b2d5a-7e89-4c11-a2f3-1d4b6c7e8f90"), Name = "# All Files", TagCategoryId = 1 },
            new Tag { EntityId = 2, BusinessId = Guid.Parse("b4c3d2e1-5f6a-4b7c-8d9e-0a1b2c3d4e5f"), Name = "New Files", TagCategoryId = 1 },
            new Tag { EntityId = 3, BusinessId = Guid.Parse("7e6d5c4b-3a2f-1e0d-9c8b-7a6f5e4d3c2b"), Name = "Audio", TagCategoryId = 2 },
            new Tag { EntityId = 4, BusinessId = Guid.Parse("1a2b3c4d-5e6f-7081-92a3-b4c5d6e7f8a9"), Name = "Image", TagCategoryId = 2 },
            new Tag { EntityId = 5, BusinessId = Guid.Parse("0f9e8d7c-6b5a-4c3d-2e1f-0a9b8c7d6e5f"), Name = "Video", TagCategoryId = 2 },
            new Tag { EntityId = 6, BusinessId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000"), Name = "*.mp3", TagCategoryId = 3 },
            new Tag { EntityId = 7, BusinessId = Guid.Parse("9abcdef0-1234-5678-9abc-def012345678"), Name = "*.bmp", TagCategoryId = 4 },
            new Tag { EntityId = 8, BusinessId = Guid.Parse("fedcba98-7654-3210-fedc-ba9876543210"), Name = "*.gif", TagCategoryId = 4 },
            new Tag { EntityId = 9, BusinessId = Guid.Parse("0a1b2c3d-4e5f-6071-8273-94a5b6c7d8e9"), Name = "*.jpeg", TagCategoryId = 4 },
            new Tag { EntityId = 10, BusinessId = Guid.Parse("11223344-5566-7788-99aa-bbccddeeff00"), Name = "*.jpg", TagCategoryId = 4 },
            new Tag { EntityId = 11, BusinessId = Guid.Parse("00ffeedd-ccbb-aaff-8877-665544332211"), Name = "*.png", TagCategoryId = 4 },
            new Tag { EntityId = 12, BusinessId = Guid.Parse("abcdef01-2345-6789-abcd-ef0123456789"), Name = "*.webp", TagCategoryId = 4 },
            new Tag { EntityId = 13, BusinessId = Guid.Parse("56789abc-def0-1234-5678-9abcdef01234"), Name = "*.mp4", TagCategoryId = 5 },
            new Tag { EntityId = 14, BusinessId = Guid.Parse("43210fed-cba9-8765-4321-0fedcba98765"), Name = "*.webm", TagCategoryId = 5 },
            new Tag { EntityId = 15, BusinessId = Guid.Parse("a1b2c3d4-e5f6-7890-ab12-cd34ef56ab78"), Name = "Landscape", TagCategoryId = 6 },
            new Tag { EntityId = 16, BusinessId = Guid.Parse("87654321-0fed-cba9-8765-43210fedcba9"), Name = "Landscape ( 16:9 )", TagCategoryId = 6 },
            new Tag { EntityId = 17, BusinessId = Guid.Parse("deadbeef-0000-1111-2222-333344445555"), Name = "Portrait", TagCategoryId = 6 },
            new Tag { EntityId = 18, BusinessId = Guid.Parse("faceb00c-1234-5678-9abc-def123456789"), Name = "Portrait ( 16:9 )", TagCategoryId = 6 },
            new Tag { EntityId = 19, BusinessId = Guid.Parse("cafebabE-0001-0002-0003-000400050006"), Name = "Square ( 1:1 )", TagCategoryId = 6 }
        );
    }
}