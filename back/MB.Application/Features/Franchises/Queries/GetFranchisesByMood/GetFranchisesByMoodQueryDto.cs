namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood;

public class GetFranchisesByMoodQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description {  get; set; } = string.Empty;
}