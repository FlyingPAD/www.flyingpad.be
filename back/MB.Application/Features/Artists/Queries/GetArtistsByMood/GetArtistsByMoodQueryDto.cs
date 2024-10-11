namespace MB.Application.Features.Artists.Queries.GetArtistsByMood;

public class GetArtistsByMoodQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}