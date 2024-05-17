namespace MB.Domain.Entities;

public class RelationArtistStyle
{
    public int ArtistId { get; set; }
    public int StyleId { get; set; }

    // Navigation Properties
    public Artist? Artist { get; set; }
    public Style? Style { get; set; }
}
