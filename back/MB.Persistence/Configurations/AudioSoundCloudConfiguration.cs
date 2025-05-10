using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class AudioSoundCloudConfiguration : IEntityTypeConfiguration<AudioSoundCloud>
{
    public void Configure(EntityTypeBuilder<AudioSoundCloud> builder)
    {
        builder.ToTable("Moods");
        builder.Property(a => a.Url)
               .HasColumnName("Url");

        builder.Property(a => a.ThumbnailUrl)
               .HasColumnName("ThumbnailUrl")
               .IsRequired();
        builder.Property(a => a.EmbedUrl)
               .HasColumnName("EmbedUrl")
               .IsRequired();
    }
}