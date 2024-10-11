namespace MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel
{
    public class GetFranchisesCheckBoxesByModelQueryDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsChecked { get; set; }
    }
}