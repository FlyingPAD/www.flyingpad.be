namespace MB.Domain.Entities
{
    public class RelationMoodArtist
    {
        public int MoodId { get; set; } = 0;
        public int ArtistId { get; set; } = 0;

        // Navigation Properties :

        public Mood? Mood { get; set; }
        public Artist? Artist { get; set; }

    }
}