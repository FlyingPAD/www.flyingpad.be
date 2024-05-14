using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByArtist
{
    public class CheckRelationsArtistStyleByArtistQueryHandler(IBaseRelationRepository<RelationArtistStyle> relationRepository, IBaseRepository<Artist> artistRepository, CheckRelationsArtistStyleByArtistQueryValidator validator) : IRequestHandler<CheckRelationsArtistStyleByArtistQuery, CheckRelationsArtistStyleByArtistQueryResponse>
    {
        private readonly IBaseRelationRepository<RelationArtistStyle> _relationRepository = relationRepository;
        private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
        private readonly CheckRelationsArtistStyleByArtistQueryValidator _validator = validator;

        public async Task<CheckRelationsArtistStyleByArtistQueryResponse> Handle(CheckRelationsArtistStyleByArtistQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count != 0)
            {
                return new CheckRelationsArtistStyleByArtistQueryResponse
                {
                    Success = false,
                    Message = "Validation Error(s)",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            int? artistPrimaryId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.ArtistId);
            if (!artistPrimaryId.HasValue)
            {
                return new CheckRelationsArtistStyleByArtistQueryResponse
                {
                    Success = false,
                    Message = "Artist was not found."
                };
            }

            int numberOfRelations = await _relationRepository.CountRelationsByMainEntityIdAsync(artistPrimaryId.Value, "ArtistId");

            return new CheckRelationsArtistStyleByArtistQueryResponse
            {
                Success = true,
                Message = $"Number of artist-style relations : {numberOfRelations}",
                NumberOfRelations = numberOfRelations
            };
        }
    }
}
