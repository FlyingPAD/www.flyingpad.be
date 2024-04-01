using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Commands.UpdateArtist
{
    public class UpdateArtistCommandHandler : IRequestHandler<UpdateArtistCommand, BaseResponse>
    {
        private readonly UpdateArtistCommandValidator _validator;
        private readonly IBaseRepository<Artist> _artistRepository;

        public UpdateArtistCommandHandler(UpdateArtistCommandValidator validator, IBaseRepository<Artist> artistRepository)
        {
            _artistRepository = artistRepository;
            _validator = validator;
        }

        public async Task<BaseResponse> Handle(UpdateArtistCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Validation failed. Please correct the following errors :",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            var artist = await _artistRepository.GetByBusinessIdAsync(request.BusinessId);

            if (artist == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Artist not found. Please ensure you are using a valid identifier.",
                    ValidationErrors = { $"Artist with ID {request.BusinessId} was not found." }
                };
            }
            artist.Name = request.Name;

            await _artistRepository.UpdateAsync(artist);

            return new BaseResponse
            {
                Success = true,
                Message = "Artist updated successfully."
            };
        }
    }
}