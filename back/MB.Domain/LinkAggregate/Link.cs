﻿using MB.Domain.ArtistAggregate;

namespace MB.Domain.LinkAggregate;

public class Link : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    public ICollection<RelationLinkArtist>? LinkArtists { get; set; }
    public ICollection<RelationLinkCategory>? LinkCategories { get; set; }
    public ICollection<RelationLinkModel>? LinkModels { get; set; }
}