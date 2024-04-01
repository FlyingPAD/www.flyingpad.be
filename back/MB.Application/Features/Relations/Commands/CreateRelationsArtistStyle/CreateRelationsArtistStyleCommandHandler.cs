using MB.Application.Contracts.Persistence;
using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Relations.Commands.RAS
{
    public class CreateRelationsArtistStyleCommandHandler : IRequestHandler<CreateRelationsArtistStyleCommand, BaseResponse>
    {
        private readonly CreateRelationsArtistStyleCommandValidator _validator;
        private readonly IArtistRepository _artistRepository;
        private readonly IStyleRepository _styleRepository;
        private readonly IRelationRepository _relationRepository;

        public CreateRelationsArtistStyleCommandHandler(CreateRelationsArtistStyleCommandValidator validator, IArtistRepository artistRepository, IStyleRepository styleRepository, IRelationRepository relationRepository)
        {
            _validator = validator;
            _artistRepository = artistRepository;
            _styleRepository = styleRepository;
            _relationRepository = relationRepository;
        }

        public async Task<BaseResponse> Handle(CreateRelationsArtistStyleCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
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
                    Message = "Artist not found."
                };
            }

            var stylePrimaryIds = await _styleRepository.GetPrimaryIdsByBusinessIdsAsync(request.StyleIds);
            if (stylePrimaryIds.Count != request.StyleIds.Count)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "One or more styles not found."
                };
            }

            await _relationRepository.RASInsertAsync(artistPrimaryId.Value, stylePrimaryIds);

            return new BaseResponse
            {
                Success = true,
                Message = "Relations created successfully."
            };
        }
    }
}