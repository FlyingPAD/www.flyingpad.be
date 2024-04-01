using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Artists.Commands.DeleteArtist;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask
{
    public class DeleteArtistCommandHandler(IBaseRepository<Artist> artistRepository, IRelationRepository relationRepository, DeleteArtistCommandValidator validator) : IRequestHandler<DeleteArtistCommand, BaseResponse>
    {
        private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
        private readonly IRelationRepository _relationRepository = relationRepository;
        private readonly DeleteArtistCommandValidator _validator = validator;

        public async Task<BaseResponse> Handle(DeleteArtistCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                return new BaseResponse
                {
                    Message = "Error(s)...",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            var artist = await _artistRepository.GetByBusinessIdAsync(request.BusinessId);

            if (artist == null)
            {
                return new BaseResponse
                {
                    Message = "Error(s)...",
                    ValidationErrors = { $"Artist with ID {request.BusinessId} was not found." }
                };
            }

            // Delete Existing Relations

            await _relationRepository.DeleteRelationsByArtistIdAsync(artist.EntityId);

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