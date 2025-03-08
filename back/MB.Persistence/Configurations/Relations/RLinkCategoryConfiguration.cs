using MB.Domain.LinkAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RLinkCategoryConfiguration : IEntityTypeConfiguration<RelationLinkCategory>
{
    public void Configure(EntityTypeBuilder<RelationLinkCategory> builder)
    {
        builder.HasKey(relation => new { relation.LinkId, relation.LinkCategoryId });

        builder.HasOne(relation => relation.Link)
            .WithMany(link => link.LinkCategories)
            .HasForeignKey(relation => relation.LinkId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.LinkCategory)
            .WithMany(category => category.RLinkCategories)
            .HasForeignKey(relation => relation.LinkCategoryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}