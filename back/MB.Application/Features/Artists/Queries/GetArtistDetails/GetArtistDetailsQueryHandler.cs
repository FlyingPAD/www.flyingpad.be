using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistDetails;

public class GetArtistDetailsQueryHandler(IMapper mapper, IBaseRepository<Artist> artistRepository) : IRequestHandler<GetArtistDetailsQuery, GetArtistDetailsQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;

    public async Task<GetArtistDetailsQueryResponse> Handle(GetArtistDetailsQuery request, CancellationToken cancellationToken)
    {
        var artist = await _artistRepository.GetByBusinessIdAsync(request.ArtistId);

        if (artist == null)
        {
            return new GetArtistDetailsQueryResponse { Success = false, Message = "Artist wasn't found." };
        }

        var artistVm = _mapper.Map<GetArtistDetailsVm>(artist);

        return new GetArtistDetailsQueryResponse
        {
            Success = true,
            Message = $"Artist : {artistVm.Name}",
            Artist = artistVm
        };
    }
}
