namespace MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;

public class GetArtistCheckBoxesByMoodQueryDto
{
    public Guid BusinessId { get; set; } = Guid.Empty;
    public string Name { get; set; } = "";
    public bool IsChecked { get; set; } = false;
}