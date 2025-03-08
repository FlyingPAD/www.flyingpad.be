using MB.Domain.ArtistAggregate;

namespace MB.Domain.MoodAggregate;

public class RelationMoodArtist
{
    public int MoodId { get; set; }
    public int ArtistId { get; set; }

    public Mood? Mood { get; set; }
    public Artist? Artist { get; set; }

}