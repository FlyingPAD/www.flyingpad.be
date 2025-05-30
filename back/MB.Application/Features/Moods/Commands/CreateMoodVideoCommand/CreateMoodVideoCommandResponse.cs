using MB.Application.Models;

namespace MB.Application.Features.Moods.Commands.CreateMoodVideoCommand;

public class CreateMoodVideoCommandResponse : BaseResponse
{
    public Guid MoodId { get; set; }
}