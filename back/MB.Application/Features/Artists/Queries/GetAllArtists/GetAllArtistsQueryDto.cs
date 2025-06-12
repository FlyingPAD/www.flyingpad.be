namespace MB.Application.Features.Artists.Queries.GetAllArtists;

public class GetAllArtistsQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}