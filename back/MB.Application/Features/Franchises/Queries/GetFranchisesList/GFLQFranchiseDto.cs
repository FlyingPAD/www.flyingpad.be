namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GFLQFranchiseDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<GFLQModelDto> Models { get; set; } = [];
}