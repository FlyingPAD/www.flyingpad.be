namespace MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;

public class GetModelCheckBoxesByMoodQueryDto
{
    public Guid BusinessId { get; set; }
    public string Pseudonym { get; set; } = string.Empty;
    public bool IsChecked { get; set; }
}