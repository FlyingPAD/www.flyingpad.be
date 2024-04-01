namespace MB.Application.Features.Franchises.Queries.GetFranchisesByModel
{
    public class GetFranchisesByModelQueryVm
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
