﻿using MB.Domain.StyleAggregate;

namespace MB.Domain.ArtistAggregate;

public class RelationArtistStyle
{
    public int ArtistId { get; set; }
    public int StyleId { get; set; }

    public Artist? Artist { get; set; }
    public Style? Style { get; set; }
}