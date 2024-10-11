namespace MB.Application.Features.Franchises.Queries.GetFranchisesByModel;

public class GetFranchisesByModelQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}