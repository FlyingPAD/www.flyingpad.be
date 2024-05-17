namespace MB.Application.Features.Models.Queries.GetModelsByFranchise;

public class GetModelsByFranchiseQueryVm
{
    public Guid BusinessId { get; set; } = Guid.Empty;
    public string Pseudonym { get; set; } = string.Empty;
    public string Gender {  get; set; } = string.Empty;
}