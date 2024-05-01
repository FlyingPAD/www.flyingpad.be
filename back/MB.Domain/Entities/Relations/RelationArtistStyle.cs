namespace MB.Domain.Entities
{
    public class RelationArtistStyle
    {
        public int ArtistId { get; set; } = 0;
        public int StyleId { get; set; } = 0;

        // Navigation Properties :

        public Artist? Artist { get; set; }
        public Style? Style { get; set; }
    }
}
