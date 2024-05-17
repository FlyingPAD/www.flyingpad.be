namespace MB.Domain.Entities;

public class RelationMoodArtist
{
    public int MoodId { get; set; }
    public int ArtistId { get; set; }

    // Navigation Properties
    public Mood? Mood { get; set; }
    public Artist? Artist { get; set; }

}