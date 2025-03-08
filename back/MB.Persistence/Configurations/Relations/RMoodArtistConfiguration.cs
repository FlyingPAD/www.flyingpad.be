using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RMoodArtistConfiguration : IEntityTypeConfiguration<RelationMoodArtist>
{
    public void Configure(EntityTypeBuilder<RelationMoodArtist> builder)
    {
        builder.HasKey(relation => new { relation.MoodId, relation.ArtistId });

        builder.HasOne(relation => relation.Mood)
            .WithMany(mood => mood.MoodArtists)
            .HasForeignKey(relation => relation.MoodId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Artist)
            .WithMany(artist => artist.MoodArtists)
            .HasForeignKey(relation => relation.ArtistId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}