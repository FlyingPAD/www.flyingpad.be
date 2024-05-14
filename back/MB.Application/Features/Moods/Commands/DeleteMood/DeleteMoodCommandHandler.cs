using MB.Application.Contracts.Persistence.Common;
using MB.Application.Contracts;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MB.Application.Features.Moods.Commands.DeleteMood
{
    public class DeleteMoodCommandHandler : IRequestHandler<DeleteMoodCommand, BaseResponse>
    {
        private readonly IBaseRepository<Mood> _moodRepo;
        private readonly IBaseRelationRepository<RelationMoodTag> _relationMoodTagRepo;
        private readonly IBaseRelationRepository<RelationMoodArtist> _relationMoodArtistRepo;
        private readonly IBaseRelationRepository<RelationMoodModel> _relationMoodModelRepo;
        private readonly IFileService _fileService;

        public DeleteMoodCommandHandler(
            IBaseRepository<Mood> moodRepo,
            IBaseRelationRepository<RelationMoodTag> relationMoodTagRepo,
            IBaseRelationRepository<RelationMoodArtist> relationMoodArtistRepo,
            IBaseRelationRepository<RelationMoodModel> relationMoodModelRepo,
            IFileService fileService)
        {
            _moodRepo = moodRepo;
            _relationMoodTagRepo = relationMoodTagRepo;
            _relationMoodArtistRepo = relationMoodArtistRepo;
            _relationMoodModelRepo = relationMoodModelRepo;
            _fileService = fileService;
        }

        public async Task<BaseResponse> Handle(DeleteMoodCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse();
            var validator = new DeleteMoodCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                response.ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                return response;
            }

            var mood = await _moodRepo.GetByBusinessIdAsync(request.MoodId);

            if (mood != null)
            {
                response.Success = true;

                // Delete Existing Relations
                await _relationMoodTagRepo.DeleteRelationsByMainEntityIdAsync(mood.EntityId, "MoodId");
                await _relationMoodArtistRepo.DeleteRelationsByMainEntityIdAsync(mood.EntityId, "MoodId");
                await _relationMoodModelRepo.DeleteRelationsByMainEntityIdAsync(mood.EntityId, "MoodId");

                // Delete Files
                await _fileService.DeleteMoodAsync("Content", mood.BusinessId, mood.Extension);

                // Delete Mood
                await _moodRepo.DeleteAsync(mood);

                response.Message = "Mood deleted successfully.";
            }
            else
            {
                response.ValidationErrors.Add("Mood was not found.");
            }

            return response;
        }
    }
}
