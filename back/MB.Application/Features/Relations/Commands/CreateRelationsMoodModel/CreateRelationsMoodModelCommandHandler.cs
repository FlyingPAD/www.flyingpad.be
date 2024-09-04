using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodModel;

public class CreateRelationsMoodModelCommandHandler(IMoodRepository moodRepository, IModelRepository modelRepository) : IRequestHandler<CreateRelationsMoodModelCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IModelRepository _modelRepository = modelRepository;

    public async Task<BaseResponse> Handle(CreateRelationsMoodModelCommand request, CancellationToken cancellationToken)
    {
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