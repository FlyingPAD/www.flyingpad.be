using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class MoodConfiguration : IEntityTypeConfiguration<Mood>
{
    public void Configure(EntityTypeBuilder<Mood> builder)
    {
        builder.HasKey(mood => mood.EntityId);
        builder.Property(mood => mood.EntityId).ValueGeneratedOnAdd();

        builder.Property(mood => mood.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(mood => mood.Description)
           .IsRequired()
           .HasMaxLength(250);

        builder.Property(mood => mood.Score)
           .IsRequired()
           .HasDefaultValue(0);

        builder.Property(mood => mood.Position)
           .IsRequired()
           .HasDefaultValue(0);

        builder.Property(mood => mood.IsApproved)
           .IsRequired()
           .HasDefaultValue(false);

        builder.Property(mood => mood.Extension)
           .IsRequired()
           .HasMaxLength(10);

        builder.ToTable("Moods")
            .HasDiscriminator<int>(mood => mood.Type)
            .HasValue<Mood>(0)
            .HasValue<Image>(1)
            .HasValue<Video>(2)
            .HasValue<Document>(3)
            .HasValue<VideoYouTube>(4)
            .HasValue<AudioSoundCloud>(5);
    }
}