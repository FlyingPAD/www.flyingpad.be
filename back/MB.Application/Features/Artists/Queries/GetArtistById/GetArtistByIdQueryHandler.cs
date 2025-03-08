using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.ArtistAggregate;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistById;

public class GetArtistByIdQueryHandler(IMapper mapper, IBaseRepository<Artist> artistRepository) : IRequestHandler<GetArtistByIdQuery, GetArtistByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;

    public async Task<GetArtistByIdQueryResponse> Handle(GetArtistByIdQuery request, CancellationToken cancellationToken)
    {
        var artist = await _artistRepository.GetByBusinessIdAsync(request.ArtistId) ?? throw new NotFoundException("Artist not found.");

        return new GetArtistByIdQueryResponse()
        {
            Success = true,
            Message = $"{artist.Name}.",
            Artist = _mapper.Map<GetArtistByIdQueryDto>(artist)
        };
    }
}