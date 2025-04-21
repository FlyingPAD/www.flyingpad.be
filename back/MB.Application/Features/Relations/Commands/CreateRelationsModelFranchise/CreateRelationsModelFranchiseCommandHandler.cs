using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsModelFranchise;

public class CreateRelationsModelFranchiseCommandHandler(IModelRepository modelRepository, IFranchiseRepository franchiseRepository) : IRequestHandler<CreateRelationsModelFranchiseCommand, BaseResponse>
{
    private readonly IModelRepository _modelRepository = modelRepository;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;

    public async Task<BaseResponse> Handle(CreateRelationsModelFranchiseCommand request, CancellationToken cancellationToken)
    {
        var modelId = await _modelRepository.GetPrimaryIdByBusinessIdAsync(request.ModelId)
            ?? throw new NotFoundException("Model not found.");

        var franchiseIds = await _franchiseRepository.GetPrimaryIdsByBusinessIdsAsync(request.FranchiseIds);

        if (franchiseIds.Count != request.FranchiseIds.Count)
        {
            throw new NotFoundException("One or more franchises were not found.");
        }

        await _modelRepository.UpdateFranchises(modelId, franchiseIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Franchises updated."
        };
    }
}