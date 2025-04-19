using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMoodYouTube
{
    public class CreateMoodYouTubeCommand : IRequest<CreateMoodYouTubeCommandResponse>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}