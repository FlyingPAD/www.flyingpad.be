namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GFLQMediaDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<GFLQFranchiseDto> Franchises { get; set; } = [];
}
