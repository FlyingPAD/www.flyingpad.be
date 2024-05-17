namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GetAllFranchisesQueryVm
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
