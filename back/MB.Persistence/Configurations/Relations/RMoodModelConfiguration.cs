using MB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RMoodModelConfiguration : IEntityTypeConfiguration<RelationMoodModel>
{
    public void Configure(EntityTypeBuilder<RelationMoodModel> builder)
    {
        builder.HasKey(relation => new { relation.MoodId, relation.ModelId });

        builder.HasOne(relation => relation.Mood)
            .WithMany(mood => mood.MoodModels)
            .HasForeignKey(relation => relation.MoodId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Model)
            .WithMany(model => model.MoodModels)
            .HasForeignKey(relation => relation.ModelId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}