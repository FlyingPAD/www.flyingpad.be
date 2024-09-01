using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(tag => tag.EntityId);
        builder.Property(tag => tag.EntityId).ValueGeneratedOnAdd();
        builder.Property(tag => tag.Name)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(tag => tag.Description)
            .HasMaxLength(200);
        builder.HasOne(tag => tag.TagCategory)
               .WithMany(tc => tc.Tags) 
               .HasForeignKey(tag => tag.TagCategoryId)
               .OnDelete(DeleteBehavior.Restrict); 
    }
}