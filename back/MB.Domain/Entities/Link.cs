using MB.Domain.Common;

namespace MB.Domain.Entities;

public class Link : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    // Navigation Properties :

    public ICollection<RelationLinkArtist>? LinkArtists { get; set; }
    public ICollection<RelationLinkCategory>? LinkCategories { get; set; }
    public ICollection<RelationLinkModel>? LinkModels { get; set; }
}