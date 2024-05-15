using MB.Application.Contracts.Persistence;
using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodModel
{
    public class CreateRelationsMoodModelCommandHandler(CreateRelationsMoodModelCommandValidator validator, IMoodRepository moodRepository, IModelRepository modelRepository) : IRequestHandler<CreateRelationsMoodModelCommand, BaseResponse>
    {
        private readonly CreateRelationsMoodModelCommandValidator _validator = validator;
        private readonly IMoodRepository _moodRepository = moodRepository;
        private readonly IModelRepository _modelRepository = modelRepository;

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

            await _moodRepository.UpdateModels((int)moodPrimaryId, modelsPrimaryIds);

            return new BaseResponse
            {
                Success = true,
                Message = "Relations created successfully."
            };
        }
    }
}
