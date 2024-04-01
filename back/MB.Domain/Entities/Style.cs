using MB.Domain.Common;

namespace MB.Domain.Entities
{
    public class Style : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation Properties :

        public ICollection<RelationArtistStyle>? ArtistStyles { get; set; }
    }
}