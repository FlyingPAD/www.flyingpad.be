namespace MB.Application.Features.Moods.Commands.CreateMood;

public class CreateMoodDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
