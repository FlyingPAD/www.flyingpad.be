using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class VideoYouTubeConfiguration : IEntityTypeConfiguration<VideoYouTube>
{
    public void Configure(EntityTypeBuilder<VideoYouTube> builder)
    {
        builder.ToTable("Moods");

        builder.Property(v => v.Url).HasColumnName("Url");
    }
}