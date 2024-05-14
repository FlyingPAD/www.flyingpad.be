using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodModel
{
    public class CreateRelationsMoodModelCommandHandler(
        CreateRelationsMoodModelCommandValidator validator,
        IBaseRepository<Mood> moodRepository,
        IModelRepository modelRepository,
        IBaseRelationRepository<RelationMoodModel> relationRepository) : IRequestHandler<CreateRelationsMoodModelCommand, BaseResponse>
    {
        private readonly CreateRelationsMoodModelCommandValidator _validator = validator;
        private readonly IBaseRepository<Mood> _moodRepository = moodRepository;
        private readonly IModelRepository _modelRepository = modelRepository;
        private readonly IBaseRelationRepository<RelationMoodModel> _relationRepository = relationRepository;

        public async Task<BaseResponse> Handle(CreateRelationsMoodModelCommand request, CancellationToken cancellationToken)
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

            var modelsPrimaryIds = await _modelRepository.GetPrimaryIdsByBusinessIdsAsync(request.ModelIds);
            if (modelsPrimaryIds.Count != request.ModelIds.Count)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "One or more models were not found."
                };
            }

            await _relationRepository.InsertRelationsAsync(moodPrimaryId.Value, modelsPrimaryIds, "MoodId", "ModelId");

            return new BaseResponse
            {
                Success = true,
                Message = "Relations created successfully."
            };
        }
    }
}
