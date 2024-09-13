using MB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RArtistStyleConfiguration : IEntityTypeConfiguration<RelationArtistStyle>
{
    public void Configure(EntityTypeBuilder<RelationArtistStyle> builder)
    {
        builder.HasKey(relation => new { relation.ArtistId, relation.StyleId });

        builder.HasOne(relation => relation.Artist)
            .WithMany(artist => artist.ArtistStyles)
            .HasForeignKey(relation => relation.ArtistId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Style)
            .WithMany(style => style.ArtistStyles)
            .HasForeignKey(relation => relation.StyleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}