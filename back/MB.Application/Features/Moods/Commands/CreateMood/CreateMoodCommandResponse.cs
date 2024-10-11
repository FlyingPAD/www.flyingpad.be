using MB.Application.Models;

namespace MB.Application.Features.Moods.Commands.CreateMood;

public class CreateMoodCommandResponse : BaseResponse
{
    public Guid MoodId { get; set; }
}