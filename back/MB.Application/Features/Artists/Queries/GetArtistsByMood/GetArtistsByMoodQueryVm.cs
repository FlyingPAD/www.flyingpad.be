namespace MB.Application.Features.Artists.Queries.GetArtistsByMood
{
    public class GetArtistsByMoodQueryVm
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
    }
}