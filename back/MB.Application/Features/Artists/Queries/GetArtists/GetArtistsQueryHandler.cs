using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtists;

public class GetArtistsQueryHandler(IBaseRepository<Artist> artistRepository, IMapper mapper) : IRequestHandler<GetArtistsQuery, GetArtistsQueryResponse>
{
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetArtistsQueryResponse> Handle(GetArtistsQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var artists = await _artistRepository.GetAllAsync();
            var response = new GetArtistsQueryResponse
            {
                Success = true,
                Message = "Here are the Artists !",
                Artists = _mapper.Map<List<GetArtistsVm>>(artists)
            };

            return response;
        }
        catch (Exception ex)
        {
            // Gérez l'exception et renvoyez une réponse d'erreur
            var response = new GetArtistsQueryResponse
            {
                Success = false,
                ValidationErrors = [$"Une erreur s'est produite ( {ex} )."]
            };

            return response;
        }
    }
}
