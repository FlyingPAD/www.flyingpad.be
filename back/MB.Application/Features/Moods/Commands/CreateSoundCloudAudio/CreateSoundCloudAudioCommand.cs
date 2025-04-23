using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateSoundCloudAudio;

public class CreateSoundCloudAudioCommand : IRequest<CreateSoundCloudAudioCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}