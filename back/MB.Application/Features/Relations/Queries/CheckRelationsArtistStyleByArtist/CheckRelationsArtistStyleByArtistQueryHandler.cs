using FluentValidation;
using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByArtist
{
    public class CheckRelationsArtistStyleByArtistQueryHandler : IRequestHandler<CheckRelationsArtistStyleByArtistQuery, CheckRelationsArtistStyleByArtistQueryResponse>
    {
        private readonly IRelationRepository _relationRepository;
        private readonly IBaseRepository<Artist> _artistRepository;
        private readonly CheckRelationsArtistStyleByArtistQueryValidator _validator;

        public CheckRelationsArtistStyleByArtistQueryHandler(IRelationRepository relationRepository, IBaseRepository<Artist> artistRepository, CheckRelationsArtistStyleByArtistQueryValidator validator)
        {
            _relationRepository = relationRepository;
            _artistRepository = artistRepository;
            _validator = validator;
        }

        public async Task<CheckRelationsArtistStyleByArtistQueryResponse> Handle(CheckRelationsArtistStyleByArtistQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Any())
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

            int numberOfRelations = await _relationRepository.CheckRelationsArtistStyleByArtist(artistPrimaryId.Value);

            return new CheckRelationsArtistStyleByArtistQueryResponse
            {
                Success = true,
                Message = $"Number of artist-style relations : {numberOfRelations}",
                NumberOfRelations = numberOfRelations
            };
        }
    }
}
