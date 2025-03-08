using MB.Domain.LinkAggregate;

namespace MB.Domain.ArtistAggregate;

public class RelationLinkArtist
{
    public int LinkId { get; set; }
    public int ArtistId { get; set; }

    public Link? Link { get; set; }
    public Artist? Artist { get; set; }
}
