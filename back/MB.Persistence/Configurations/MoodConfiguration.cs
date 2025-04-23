using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class MoodConfiguration : IEntityTypeConfiguration<Mood>
{
    public void Configure(EntityTypeBuilder<Mood> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.ToTable("Moods")
            .HasDiscriminator<int>(m => m.Type)
            .HasValue<Mood>(0)
            .HasValue<Image>(1)
            .HasValue<Video>(2)
            .HasValue<Document>(3)
            .HasValue<VideoYouTube>(4)
            .HasValue<AudioSoundCloud>(5);
    }
}