using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class AudioSoundCloudConfiguration : IEntityTypeConfiguration<AudioSoundCloud>
{
    public void Configure(EntityTypeBuilder<AudioSoundCloud> builder)
    {
        builder.ToTable("Moods");               // on reste bien sur la table Moods
        builder.Property(a => a.Url)
               .HasColumnName("Url");          // déjà en place

        // Il faut ajouter ces deux lignes :
        builder.Property(a => a.ThumbnailUrl)
               .HasColumnName("ThumbnailUrl")
               .IsRequired();                  // ou .IsRequired(false) si tu veux autoriser NULL
        builder.Property(a => a.EmbedUrl)
               .HasColumnName("EmbedUrl")
               .IsRequired();                  // idem
    }
}