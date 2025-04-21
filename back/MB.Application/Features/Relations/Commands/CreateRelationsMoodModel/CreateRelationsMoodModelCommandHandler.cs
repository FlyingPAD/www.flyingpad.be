using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodModel;

public class CreateRelationsMoodModelCommandHandler(IMoodRepository moodRepository, IModelRepository modelRepository) : IRequestHandler<CreateRelationsMoodModelCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IModelRepository _modelRepository = modelRepository;

    public async Task<BaseResponse> Handle(CreateRelationsMoodModelCommand request, CancellationToken cancellationToken)
    {
        var moodId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var modelsPrimaryIds = await _modelRepository.GetPrimaryIdsByBusinessIdsAsync(request.ModelIds);

        if (modelsPrimaryIds.Count != request.ModelIds.Count)
        {
            throw new NotFoundException("One or more models were not found.");
        }

        await _moodRepository.UpdateModels(moodId, modelsPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Models updated."
        };
    }
}