namespace MB.Application.Features.Artists.Queries.GetArtistsByStyle;

public class GetArtistsByStyleQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}