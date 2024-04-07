namespace MB.Application.Features.Franchises.Queries.GetFranchisesList
{
    public class GFLQModelDto
    {
        public Guid BusinessId { get; set; }
        public string Pseudonym { get; set; } = string.Empty;
        public string gender { get; set; } = string.Empty;
    }
}
