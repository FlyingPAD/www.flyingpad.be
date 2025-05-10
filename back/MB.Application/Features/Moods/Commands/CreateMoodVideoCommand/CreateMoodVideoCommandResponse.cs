using MB.Application.Models;

namespace MB.Application.Features.Moods.Commands.CreateMoodVideo;

public class CreateMoodVideoCommandResponse : BaseResponse
{
    public Guid MoodId { get; set; }
}
