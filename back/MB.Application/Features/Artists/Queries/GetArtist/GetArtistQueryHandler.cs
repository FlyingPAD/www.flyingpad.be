using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtist
{
    public class GetArtistQueryHandler(IMapper mapper, IBaseRepository<Artist> artistRepository, GetArtistQueryValidator validator) : IRequestHandler<GetArtistQuery, GetArtistQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
        private readonly GetArtistQueryValidator _validator = validator;

        public async Task<GetArtistQueryResponse> Handle(GetArtistQuery request, CancellationToken cancellationToken)
        {
            //  => Validation

            // Errors :

            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                return new GetArtistQueryResponse
                {
                    Message = "Error(s)...",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            // Success :

            var getArtistQueryResponse = new GetArtistQueryResponse();
            var artist = await _artistRepository.GetByBusinessIdAsync(request.ArtistId);

            if (artist == null)
            {
                getArtistQueryResponse.Success = false;
                getArtistQueryResponse.Message = "Artist wasn't found";

                return getArtistQueryResponse;
            }

            getArtistQueryResponse.Success = true;
            getArtistQueryResponse.Message = $"Artist : {artist.Name}";
            getArtistQueryResponse.Artist = _mapper.Map<GetArtistVm>(artist);

            return getArtistQueryResponse;
        }
    }
}