using MB.Application.Contracts.Persistence;
using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodArtist
{
    public class CreateRelationsMoodArtistCommandHandler(CreateRelationsMoodArtistCommandValidator validator, IMoodRepository moodRepo, IArtistRepository artistRepo, IRelationRepository relationRepo) : IRequestHandler<CreateRelationsMoodArtistCommand, BaseResponse>
    {
        private readonly CreateRelationsMoodArtistCommandValidator _validator = validator;
        private readonly IMoodRepository _moodRepository = moodRepo;
        private readonly IArtistRepository _artistRepository = artistRepo;
        private readonly IRelationRepository _relationRepository = relationRepo;

        public async Task<BaseResponse> Handle(CreateRelationsMoodArtistCommand request, CancellationToken cancellationToken)
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

            var moodPrimaryId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId);
            if (moodPrimaryId == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Mood was not found."
                };
            }

            var artistsPrimaryIds = await _artistRepository.GetPrimaryIdsByBusinessIdsAsync(request.ArtistIds);
            if (artistsPrimaryIds.Count != request.ArtistIds.Count)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "One or more artists were not found."
                };
            }

            await _relationRepository.RMAInsertAsync(moodPrimaryId.Value, artistsPrimaryIds);

            return new BaseResponse
            {
                Success = true,
                Message = "Relations created successfully."
            };
        }
    }
}
