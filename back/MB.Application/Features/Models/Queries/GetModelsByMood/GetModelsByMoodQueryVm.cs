namespace MB.Application.Features.Models.Queries.GetModelsByMood
{
    public class GetModelsByMoodQueryVm
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public string Pseudonym { get; set; } = string.Empty;
    }
}