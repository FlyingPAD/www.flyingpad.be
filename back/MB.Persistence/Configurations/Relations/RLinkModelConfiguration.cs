using MB.Domain.ArtistAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RLinkModelConfiguration : IEntityTypeConfiguration<RelationLinkModel>
{
    public void Configure(EntityTypeBuilder<RelationLinkModel> builder)
    {
        builder.HasKey(relation => new { relation.LinkId, relation.ModelId });

        builder.HasOne(relation => relation.Link)
            .WithMany(link => link.LinkModels)
            .HasForeignKey(relation => relation.LinkId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Model)
            .WithMany(model => model.LinkModels)
            .HasForeignKey(relation => relation.ModelId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}