using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.MoodAggregate;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistsByMood;

public class GetArtistsByMoodQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepo, IArtistRepository artistRepo) : IRequestHandler<GetArtistsByMoodQuery, GetArtistsByMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Mood> _moodRepo = moodRepo;
    private readonly IArtistRepository _artistRepo = artistRepo;

    public async Task<GetArtistsByMoodQueryResponse> Handle(GetArtistsByMoodQuery request, CancellationToken cancellationToken)
    {
        int moodId = await _moodRepo.GetPrimaryIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var artists = await _artistRepo.GetArtistsByMood(moodId);

        return new GetArtistsByMoodQueryResponse
        {
            Success = true,
            Message = "Artists by mood.",
            ArtistsByMood = _mapper.Map<List<GetArtistsByMoodQueryDto>>(artists)
        };
    }
}