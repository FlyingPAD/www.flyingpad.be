using MB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RFranchiseMediaConfiguration : IEntityTypeConfiguration<RelationFranchiseMedia>
{
    public void Configure(EntityTypeBuilder<RelationFranchiseMedia> builder)
    {
        builder.HasKey(relation => new { relation.FranchiseId, relation.MediaId });

        builder.HasOne(relation => relation.Franchise)
            .WithMany(franchise => franchise.FranchiseMedias)
            .HasForeignKey(relation => relation.FranchiseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Media)
            .WithMany(media => media.FranchiseMedias)
            .HasForeignKey(relation => relation.MediaId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}