using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByStyle
{
    public class CheckRelationsArtistStyleByStyleQueryHandler(IBaseRelationRepository<RelationArtistStyle> relationRepository, IBaseRepository<Style> styleRepository, CheckRelationsArtistStyleByStyleQueryValidator validator) : IRequestHandler<CheckRelationsArtistStyleByStyleQuery, CheckRelationsArtistStyleByStyleQueryResponse>
    {
        private readonly IBaseRelationRepository<RelationArtistStyle> _relationRepository = relationRepository;
        private readonly IBaseRepository<Style> _styleRepository = styleRepository;
        private readonly CheckRelationsArtistStyleByStyleQueryValidator _validator = validator;

        public async Task<CheckRelationsArtistStyleByStyleQueryResponse> Handle(CheckRelationsArtistStyleByStyleQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count != 0)
            {
                return new CheckRelationsArtistStyleByStyleQueryResponse
                {
                    Success = false,
                    Message = "Validation Error(s)",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            int? stylePrimaryId = await _styleRepository.GetPrimaryIdByBusinessIdAsync(request.StyleId);
            if (!stylePrimaryId.HasValue)
            {
                return new CheckRelationsArtistStyleByStyleQueryResponse
                {
                    Success = false,
                    Message = "Style was not found."
                };
            }

            int numberOfRelations = await _relationRepository.CountRelationsByMainEntityIdAsync(stylePrimaryId.Value, "ArtistId");

            return new CheckRelationsArtistStyleByStyleQueryResponse
            {
                Success = true,
                Message = $"Number of artist-style relations for the style: {numberOfRelations}",
                NumberOfRelations = numberOfRelations
            };
        }
    }
}
