using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags
{
    public class CreateRelationsMoodTagsCommandHandler(
        CreateRelationsMoodTagsCommandValidator validator,
        IBaseRepository<Mood> moodRepository,
        ITagRepository tagRepository,
        IBaseRelationRepository<RelationMoodTag> relationRepository) : IRequestHandler<CreateRelationsMoodTagsCommand, BaseResponse>
    {
        private readonly CreateRelationsMoodTagsCommandValidator _validator = validator;
        private readonly IBaseRepository<Mood> _moodRepository = moodRepository;
        private readonly ITagRepository _tagRepository = tagRepository;
        private readonly IBaseRelationRepository<RelationMoodTag> _relationRepository = relationRepository;

        public async Task<BaseResponse> Handle(CreateRelationsMoodTagsCommand request, CancellationToken cancellationToken)
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
                    Message = "One or more tags were not found."
                };
            }

            await _relationRepository.InsertRelationsAsync(moodPrimaryId.Value, tagsPrimaryIds, "MoodId", "TagId");

            return new BaseResponse
            {
                Success = true,
                Message = "Relations created successfully."
            };
        }
    }
}
