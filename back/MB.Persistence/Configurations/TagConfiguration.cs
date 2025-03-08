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
    }
}