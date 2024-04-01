namespace MB.Application.Features.Moods.Commands.UpdateMood
{
    public class UpdateMoodDto
    {
        public Guid BusinessId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
