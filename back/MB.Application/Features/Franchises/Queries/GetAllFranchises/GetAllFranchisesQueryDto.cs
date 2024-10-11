namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GetAllFranchisesQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}