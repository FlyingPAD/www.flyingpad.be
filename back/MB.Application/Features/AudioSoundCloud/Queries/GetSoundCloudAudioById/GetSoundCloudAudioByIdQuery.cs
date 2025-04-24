using MediatR;

namespace MB.Application.Features.AudioSoundCloud.Queries.GetSoundCloudAudioById;

public class GetSoundCloudAudioByIdQuery : IRequest<GetSoundCloudAudioByIdQueryResponse>
{
    public Guid AudioSoundCloudId { get; set; }
}