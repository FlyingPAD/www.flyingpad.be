using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistById;

public class GetArtistByIdQueryHandler(IMapper mapper, IBaseRepository<Artist> artistRepository) : IRequestHandler<GetArtistByIdQuery, GetArtistByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;

    public async Task<GetArtistByIdQueryResponse> Handle(GetArtistByIdQuery request, CancellationToken cancellationToken)
    {
        var response = new GetArtistByIdQueryResponse();
        var artist = await _artistRepository.GetByBusinessIdAsync(request.ArtistId);

        if (artist == null)
        {
            response.Success = false;
            response.Message = "Artist was not found.";

            return response;
        }

        response.Success = true;
        response.Message = $"Artist : {artist.Name}";
        response.Artist = _mapper.Map<GetArtistByIdQueryDto>(artist);

        return response;
    }
}