using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Videos.Queries.GetOneVideoDetailsQuery
{
    public class GetOneVideoDetailsQueryHandler : IRequestHandler<GetOneVideoDetailsQuery, GetOneVideoDetailsQueryResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Video> _videoRepository;

        public GetOneVideoDetailsQueryHandler(IMapper mapper, IBaseRepository<Video> videoRepository)
        {
            _mapper = mapper;
            _videoRepository = videoRepository;
        }

        public async Task<GetOneVideoDetailsQueryResponse> Handle(GetOneVideoDetailsQuery request, CancellationToken cancellationToken)
        {
            var video = await _videoRepository.GetByBusinessIdAsync(request.VideoId);

            if (video == null)
            {
                return new GetOneVideoDetailsQueryResponse { Success = false, Message = "Video wasn't found :(" };
            }

            var videoVm = _mapper.Map<GetOneVideoDetailsQueryVm>(video);

            return new GetOneVideoDetailsQueryResponse
            {
                Success = true,
                Message = "Mood was found :)",
                Video = videoVm
            };
        }
    }
}