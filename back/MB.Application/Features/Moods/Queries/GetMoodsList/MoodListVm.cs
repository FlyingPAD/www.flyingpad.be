namespace MB.Application.Features.Moods.Queries.GetMoodsList;

public class MoodListVm
{
    public Guid BusinessId { get; set; } = Guid.Empty;
    public int Type { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Extension { get; set; } = string.Empty;
    public int Score { get; set; } = 0;
}