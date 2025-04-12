using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.MoodAggregate;
using MediatR;

namespace MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetails;

public class GetOneVideoYTDetailsQueryHandler(IMapper mapper, IBaseRepository<VideoYouTube> videoYouTubeRepository) : IRequestHandler<GetOneVideoYTDetailsQuery, GetOneVideoYTDetailsQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<VideoYouTube> _videoYouTubeRepository = videoYouTubeRepository;

    public async Task<GetOneVideoYTDetailsQueryResponse> Handle(GetOneVideoYTDetailsQuery request, CancellationToken cancellationToken)
    {
        var video = await _videoYouTubeRepository.GetByBusinessIdAsync(request.VideoYouTubeId)
            ?? throw new NotFoundException("Video not found.");

        var videoYouTubeDto = _mapper.Map<GetOneVideoYTDetailsQueryDto>(video);

        return new GetOneVideoYTDetailsQueryResponse
        {
            Success = true,
            Message = "Video YouTube Details",
            VideoYouTube = videoYouTubeDto
        };
    }
}