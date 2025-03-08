using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RMoodTagConfiguration : IEntityTypeConfiguration<RelationMoodTag>
{
    public void Configure(EntityTypeBuilder<RelationMoodTag> builder)
    {
        builder.HasKey(relation => new { relation.MoodId, relation.TagId });

        builder.HasOne(relation => relation.Mood)
            .WithMany(mood => mood.MoodTags)
            .HasForeignKey(relation => relation.MoodId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Tag)
            .WithMany(tag => tag.MoodTags)
            .HasForeignKey(relation => relation.TagId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}