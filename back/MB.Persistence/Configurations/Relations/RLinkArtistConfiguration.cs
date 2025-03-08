using MB.Domain.ArtistAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RLinkArtistConfiguration : IEntityTypeConfiguration<RelationLinkArtist>
{
    public void Configure(EntityTypeBuilder<RelationLinkArtist> builder)
    {
        builder.HasKey(relation => new { relation.LinkId, relation.ArtistId });

        builder.HasOne(relation => relation.Link)
            .WithMany(link => link.LinkArtists)
            .HasForeignKey(relation => relation.LinkId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Artist)
            .WithMany(artist => artist.LinkArtists)
            .HasForeignKey(relation => relation.ArtistId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}