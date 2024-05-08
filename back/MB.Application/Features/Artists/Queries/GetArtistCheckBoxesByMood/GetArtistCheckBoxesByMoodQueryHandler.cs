using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood
{
    public class GetArtistCheckBoxesByMoodQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepo, IArtistRepository artistRepo) : IRequestHandler<GetArtistCheckBoxesByMoodQuery, GetArtistCheckBoxesByMoodQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IBaseRepository<Mood> _moodRepo = moodRepo;
        private readonly IArtistRepository _artistRepo = artistRepo;

        public async Task<GetArtistCheckBoxesByMoodQueryResponse> Handle(GetArtistCheckBoxesByMoodQuery request, CancellationToken cancellationToken)
        {
            int? moodEntityId = await _moodRepo.GetPrimaryIdByBusinessIdAsync(request.MoodId);

            if (!moodEntityId.HasValue)
            {
                return new GetArtistCheckBoxesByMoodQueryResponse
                {
                    Success = false,
                    Message = "No mood found with the given ID"
                };
            }

            var artists = await _artistRepo.GetArtistsCheckBoxesByMood(moodEntityId.Value);

            var response = new GetArtistCheckBoxesByMoodQueryResponse
            {
                Success = true,
                Message = "Artists retrieved based on mood",
                Artists = _mapper.Map<IEnumerable<GetArtistCheckBoxesByMoodQueryDto>>(artists)
            };

            return response;
        }
    }
}
