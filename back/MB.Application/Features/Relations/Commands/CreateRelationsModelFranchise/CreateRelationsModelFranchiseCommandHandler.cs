using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsModelFranchise;

public class CreateRelationsModelFranchiseCommandHandler(IModelRepository modelRepository, IFranchiseRepository franchiseRepository) : IRequestHandler<CreateRelationsModelFranchiseCommand, BaseResponse>
{
    private readonly IModelRepository _modelRepository = modelRepository;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;

    public async Task<BaseResponse> Handle(CreateRelationsModelFranchiseCommand request, CancellationToken cancellationToken)
    {
        var modelPrimaryId = await _modelRepository.GetPrimaryIdByBusinessIdAsync(request.ModelId);
        if (modelPrimaryId == null)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Model was not found."
            };
        }

        var franchisePrimaryIds = await _franchiseRepository.GetPrimaryIdsByBusinessIdsAsync(request.FranchiseIds);
        if (franchisePrimaryIds.Count != request.FranchiseIds.Count)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "One or more franchises were not found."
            };
        }

        await _modelRepository.UpdateFranchises((int)modelPrimaryId, franchisePrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}