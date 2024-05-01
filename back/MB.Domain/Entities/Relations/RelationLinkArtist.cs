namespace MB.Domain.Entities
{
    public class RelationLinkArtist
    {
        public int LinkId { get; set; } = 0;
        public int ArtistId { get; set; } = 0;

        // Navigation Properties :

        public Link? Link { get; set; }
        public Artist? Artist { get; set; }
    }
}
