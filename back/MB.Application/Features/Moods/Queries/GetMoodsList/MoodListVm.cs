namespace MB.Application.Features.Moods.Queries.GetMoodsList
{
    public class MoodListVm
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
        public int Type { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string? Extension { get; set; } = null; 
    }
}