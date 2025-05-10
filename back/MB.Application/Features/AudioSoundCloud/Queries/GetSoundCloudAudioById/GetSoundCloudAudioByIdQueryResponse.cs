using MB.Application.Models;

namespace MB.Application.Features.AudioSoundCloud.Queries.GetSoundCloudAudioById;

public class GetSoundCloudAudioByIdQueryResponse: BaseResponse
{
    public GetSoundCloudAudioByIdQueryDto AudioSoundCloud { get; set; } = new();
}