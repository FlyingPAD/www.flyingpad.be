using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Commands.DeleteArtist
{
    public class DeleteArtistCommandHandler(
        IBaseRepository<Artist> artistRepository,
        IBaseRelationRepository<RelationArtistStyle> relationRepository,
        DeleteArtistCommandValidator validator) : IRequestHandler<DeleteArtistCommand, BaseResponse>
    {
        private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
        private readonly IBaseRelationRepository<RelationArtistStyle> _relationRepository = relationRepository;
        private readonly DeleteArtistCommandValidator _validator = validator;

        public async Task<BaseResponse> Handle(DeleteArtistCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                return new BaseResponse
                {
                    Message = "Validation Error(s)",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            var artist = await _artistRepository.GetByBusinessIdAsync(request.BusinessId);

            if (artist == null)
            {
                return new BaseResponse
                {
                    Message = "Artist was not found.",
                    ValidationErrors = { $"Artist with ID {request.BusinessId} was not found." }
                };
            }

            // Delete Existing Relations
            await _relationRepository.DeleteRelationsByMainEntityIdAsync(artist.EntityId, "ArtistId");

            // Delete Artist
            await _artistRepository.DeleteAsync(artist);

            // Return Success Response
            return new BaseResponse
            {
                Success = true,
                Message = $"Artist with ID {request.BusinessId} has been successfully deleted."
            };
        }
    }
}
