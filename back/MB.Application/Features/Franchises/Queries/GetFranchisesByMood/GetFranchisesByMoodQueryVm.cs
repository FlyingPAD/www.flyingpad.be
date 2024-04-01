namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood
{
    public class GetFranchisesByMoodQueryVm
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
    }
}