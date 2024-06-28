namespace MB.Application.Features.Models.Queries.GetModelsByMood;

public class GetModelsByMoodQueryVm
{
    public Guid BusinessId { get; set; }
    public string Pseudonym { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
}