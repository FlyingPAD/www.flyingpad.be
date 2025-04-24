using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.AudioSoundCloud.Queries.GetSoundCloudAudioById;

public class GetSoundCloudAudioByIdqueryHandler(IMapper mapper, IBaseRepository<MB.Domain.MoodAggregate.AudioSoundCloud> soundCloudRepo) : IRequestHandler<GetSoundCloudAudioByIdQuery, GetSoundCloudAudioByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<MB.Domain.MoodAggregate.AudioSoundCloud> _soundCloudRepo = soundCloudRepo;

    public async Task<GetSoundCloudAudioByIdQueryResponse> Handle(GetSoundCloudAudioByIdQuery request, CancellationToken cancellationToken)
    {
        var audio = await _soundCloudRepo.GetByBusinessIdAsync(request.AudioSoundCloudId)
            ?? throw new NotFoundException("Audio not found.");

        var audioDto = _mapper.Map<GetSoundCloudAudioByIdQueryDto>(audio);

        return new GetSoundCloudAudioByIdQueryResponse
        {
            Success = true,
            Message = "Audio SoundCloud Details",
            AudioSoundCloud = audioDto
        };
    }
}