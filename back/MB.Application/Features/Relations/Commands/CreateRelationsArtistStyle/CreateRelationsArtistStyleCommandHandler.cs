using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Commands.RAS
{
    public class CreateRelationsArtistStyleCommandHandler(
        CreateRelationsArtistStyleCommandValidator validator,
        IBaseRepository<Artist> artistRepository,
        IStyleRepository styleRepository,
        IBaseRelationRepository<RelationArtistStyle> relationRepository) : IRequestHandler<CreateRelationsArtistStyleCommand, BaseResponse>
    {
        private readonly CreateRelationsArtistStyleCommandValidator _validator = validator;
        private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
        private readonly IStyleRepository _styleRepository = styleRepository;
        private readonly IBaseRelationRepository<RelationArtistStyle> _relationRepository = relationRepository;

        public async Task<BaseResponse> Handle(CreateRelationsArtistStyleCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count != 0)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Validation Error(s)",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            var artistPrimaryId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.ArtistId);
            if (artistPrimaryId == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Artist was not found."
                };
            }

            var stylePrimaryIds = await _styleRepository.GetPrimaryIdsByBusinessIdsAsync(request.StyleIds);
            if (stylePrimaryIds.Count != request.StyleIds.Count)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "One or more styles were not found."
                };
            }

            await _relationRepository.InsertRelationsAsync(artistPrimaryId.Value, stylePrimaryIds, "ArtistId", "StyleId");

            return new BaseResponse
            {
                Success = true,
                Message = "Relations created successfully."
            };
        }
    }
}