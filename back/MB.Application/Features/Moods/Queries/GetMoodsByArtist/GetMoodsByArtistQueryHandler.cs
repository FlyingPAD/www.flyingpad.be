using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByArtist;

public class GetMoodsByArtistQueryHandler(IMapper mapper, IMoodRepository moodRepository, IArtistRepository artistRepository) : IRequestHandler<GetMoodsByArtistQuery, GetMoodsByArtistQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IArtistRepository _artistRepository = artistRepository;

    public async Task<GetMoodsByArtistQueryResponse> Handle(GetMoodsByArtistQuery request, CancellationToken cancellationToken)
    {
        int artistId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.ArtistId)
            ?? throw new NotFoundException("Artist not found.");

        var moods = await _moodRepository.GetMoodsByArtist(artistId);

        return new GetMoodsByArtistQueryResponse
        {
            Success = true,
            Message = "Moods by artist.",
            Moods = _mapper.Map<List<GetMoodsByArtistQueryDto>>(moods)
        };
    }
}