using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByStyle
{
    public class CheckRelationsArtistStyleByStyleQueryHandler : IRequestHandler<CheckRelationsArtistStyleByStyleQuery, CheckRelationsArtistStyleByStyleQueryResponse>
    {
        private readonly IRelationRepository _relationRepository;
        private readonly IBaseRepository<Style> _styleRepository;
        private readonly CheckRelationsArtistStyleByStyleQueryValidator _validator;

        public CheckRelationsArtistStyleByStyleQueryHandler(IRelationRepository relationRepository, IBaseRepository<Style> styleRepository, CheckRelationsArtistStyleByStyleQueryValidator validator)
        {
            _relationRepository = relationRepository;
            _styleRepository = styleRepository;
            _validator = validator;
        }

        public async Task<CheckRelationsArtistStyleByStyleQueryResponse> Handle(CheckRelationsArtistStyleByStyleQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Any())
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

            int numberOfRelations = await _relationRepository.CheckRelationsArtistStyleByStyle(stylePrimaryId.Value);

            return new CheckRelationsArtistStyleByStyleQueryResponse
            {
                Success = true,
                Message = $"Number of artist-style relations for the style: {numberOfRelations}",
                NumberOfRelations = numberOfRelations
            };
        }
    }
}