namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedia;

public class GetFranchisesByMediaQueryVm
{
    public Guid BusinessId { get; set; } = Guid.Empty;
    public string Name { get; set; } = string.Empty;
}
