using AutoMapper;
using MediatR;
using MB.Application.Interfaces.Persistence;
using MB.Application.Exceptions;
using MB.Domain.MoodAggregate;

namespace MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;

public class GetArtistCheckBoxesByMoodQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepo, IArtistRepository artistRepo) : IRequestHandler<GetArtistCheckBoxesByMoodQuery, GetArtistCheckBoxesByMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Mood> _moodRepo = moodRepo;
    private readonly IArtistRepository _artistRepo = artistRepo;

    public async Task<GetArtistCheckBoxesByMoodQueryResponse> Handle(GetArtistCheckBoxesByMoodQuery request, CancellationToken cancellationToken)
    {
        int moodId = await _moodRepo.GetPrimaryIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var artists = await _artistRepo.GetArtistsCheckBoxesByMood(moodId);

        return new GetArtistCheckBoxesByMoodQueryResponse
        {
            Success = true,
            Message = "Checkboxes / Artists",
            Artists = _mapper.Map<IEnumerable<GetArtistCheckBoxesByMoodQueryDto>>(artists)
        };
    }
}