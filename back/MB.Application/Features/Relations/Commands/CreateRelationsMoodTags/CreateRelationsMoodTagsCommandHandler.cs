using MB.Application.Contracts.Persistence;
using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags
{
    public class CreateRelationsMoodTagsCommandHandler(CreateRelationsMoodTagsCommandValidator validator, IMoodRepository moodRepo, ITagRepository tagRepo, IRelationRepository relationRepo) : IRequestHandler<CreateRelationsMoodTagsCommand, BaseResponse>
    {
        private readonly CreateRelationsMoodTagsCommandValidator _validator = validator;
        private readonly IMoodRepository _moodRepository = moodRepo;
        private readonly ITagRepository _tagRepository = tagRepo;
        private readonly IRelationRepository _relationRepository = relationRepo;

        public async Task<BaseResponse> Handle(CreateRelationsMoodTagsCommand request, CancellationToken cancellationToken)
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

            var tagsPrimaryIds = await _tagRepository.GetPrimaryIdsByBusinessIdsAsync(request.TagIds);
            if (tagsPrimaryIds.Count != request.TagIds.Count)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "One or more styles were not found."
                };
            }

            await _relationRepository.RMTInsertAsync(moodPrimaryId.Value, tagsPrimaryIds);

            return new BaseResponse
            {
                Success = true,
                Message = "Relations created successfully."
            };
        }
    }
}
