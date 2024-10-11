namespace MB.Application.Features.Styles.Queries.GetAllStyles;

public class GetAllStylesQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}