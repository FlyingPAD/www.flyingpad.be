using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetailsQuery;

public class GetOneVideoYTDetailsQueryHandler(IMapper mapper, IBaseRepository<VideoYouTube> videoYouTubeRepository) : IRequestHandler<GetOneVideoYTDetailsQuery, GetOneVideoYTDetailsQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<VideoYouTube> _videoYouTubeRepository = videoYouTubeRepository;

    public async Task<GetOneVideoYTDetailsQueryResponse> Handle(GetOneVideoYTDetailsQuery request, CancellationToken cancellationToken)
    {
        var video = await _videoYouTubeRepository.GetByBusinessIdAsync(request.VideoYouTubeId);

        if (video == null)
        {
            return new GetOneVideoYTDetailsQueryResponse { Success = false, Message = "Video wasn't found :(" };
        }

        var videoYouTubeVm = _mapper.Map<GetOneVideoYTDetailsQueryVm>(video);

        return new GetOneVideoYTDetailsQueryResponse
        {
            Success = true,
            Message = "Mood was found :)",
            VideoYouTube = videoYouTubeVm
        };
    }
}