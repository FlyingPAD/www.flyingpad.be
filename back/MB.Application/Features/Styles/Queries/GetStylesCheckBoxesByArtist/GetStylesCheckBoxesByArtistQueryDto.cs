namespace MB.Application.Features.Styles.Queries.GetStylesCheckBoxesByArtist;

public class GetStylesCheckBoxesByArtistQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsChecked { get; set; }
}