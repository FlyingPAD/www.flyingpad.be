using MB.Domain.ArtistAggregate;

namespace MB.Domain.StyleAggregate;

public class Style : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<RelationArtistStyle>? ArtistStyles { get; set; }
}