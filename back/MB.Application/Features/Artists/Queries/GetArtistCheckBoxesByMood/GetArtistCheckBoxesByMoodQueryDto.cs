namespace MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;

public class GetArtistCheckBoxesByMoodQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsChecked { get; set; }
}