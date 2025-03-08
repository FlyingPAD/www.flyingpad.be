using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RMoodFranchiseConfiguration : IEntityTypeConfiguration<RelationMoodFranchise>
{
    public void Configure(EntityTypeBuilder<RelationMoodFranchise> builder)
    {
        builder.HasKey(relation => new { relation.MoodId, relation.FranchiseId });

        builder.HasOne(relation => relation.Mood)
            .WithMany(mood => mood.MoodFranchises)
            .HasForeignKey(relation => relation.MoodId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Franchise)
            .WithMany(franchise => franchise.MoodFranchises)
            .HasForeignKey(relation => relation.FranchiseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}