using AutoMapper;
using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistsByMood
{
    public class GetArtistsByMoodQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepo, IArtistRepository artistRepo) : IRequestHandler<GetArtistsByMoodQuery, GetArtistsByMoodQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IBaseRepository<Mood> _moodRepo = moodRepo;
        private readonly IArtistRepository _artistRepo = artistRepo;

        public async Task<GetArtistsByMoodQueryResponse> Handle(GetArtistsByMoodQuery request, CancellationToken cancellationToken)
        {
            int? moodId = await _moodRepo.GetPrimaryIdByBusinessIdAsync(request.BusinessId);

            var artists = await _artistRepo.GetArtistsByMood(moodId);

            var response = new GetArtistsByMoodQueryResponse
            {
                Success = true,
                Message = "Artists By Mood",
                ArtistsByMood = _mapper.Map<List<GetArtistsByMoodQueryVm>>(artists)
            };

            return response;
        }
    }
}