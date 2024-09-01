namespace MB.Application.Features.Artists.Queries.GetArtistById;

public class GetArtistByIdQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
