namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedium;

public class GetFranchisesByMediumQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}