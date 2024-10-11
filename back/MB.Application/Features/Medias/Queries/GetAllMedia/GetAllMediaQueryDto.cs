namespace MB.Application.Features.Medias.Queries.GetAllMedia;

public class GetAllMediaQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}