﻿using MB.Domain.MoodAggregate;

namespace MB.Domain.ArtistAggregate;

public class Artist : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Pseudonym { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<RelationMoodArtist>? MoodArtists { get; set; }
    public ICollection<RelationArtistStyle>? ArtistStyles { get; set; }
    public ICollection<RelationLinkArtist>? LinkArtists { get; set; }
}