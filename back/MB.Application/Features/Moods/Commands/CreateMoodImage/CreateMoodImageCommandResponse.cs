using MB.Application.Responses;

namespace MB.Application.Features.Moods.Commands.CreateMoodImage
{
    public class CreateMoodImageCommandResponse : BaseResponse
    {
        public CreateMoodImageCommandDto Mood { get; set; } = new();
    }
}