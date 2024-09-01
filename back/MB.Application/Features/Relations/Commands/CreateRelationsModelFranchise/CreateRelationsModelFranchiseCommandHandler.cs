using MB.Application.Contracts.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsModelFranchise;

public class CreateRelationsModelFranchiseCommandHandler : IRequestHandler<CreateRelationsModelFranchiseCommand, BaseResponse>
{
    private readonly IModelRepository _modelRepository;
    private readonly IFranchiseRepository _franchiseRepository;
    private readonly CreateRelationsModelFranchiseCommandValidator _validator;

    public CreateRelationsModelFranchiseCommandHandler(IModelRepository modelRepository, IFranchiseRepository franchiseRepository, CreateRelationsModelFranchiseCommandValidator validator)
    {
        _modelRepository = modelRepository;
        _franchiseRepository = franchiseRepository;
        _validator = validator;
    }

    public async Task<BaseResponse> Handle(CreateRelationsModelFranchiseCommand request, CancellationToken cancellationToken)
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