using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Models.Commands.UpdateModel;

public class UpdateModelCommandHandler(IModelRepository modelRepository, IFranchiseRepository franchiseRepository) : IRequestHandler<UpdateModelCommand, BaseResponse>
{
    private readonly IModelRepository _modelRepository = modelRepository;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;

    public async Task<BaseResponse> Handle(UpdateModelCommand request, CancellationToken cancellationToken)
    {
        var modelId = await _modelRepository.GetPrimaryIdByBusinessIdAsync(request.ModelId)
            ?? throw new NotFoundException("Model not found.");

        var model = await _modelRepository.GetModelWithFranchisesAsync(modelId)
            ?? throw new NotFoundException("Model not found.");

        model.Pseudonym = request.Pseudonym;
        model.FirstName = request.FirstName;
        model.LastName = request.LastName;
        model.Gender = request.Gender;
        model.Description = request.Description;


        await _modelRepository.UpdateAsync(model);

        await _modelRepository.RemoveFranchisesAsync(model);

        var franchisesIds = await _franchiseRepository.GetPrimaryIdsByBusinessIdsAsync(request.FranchisesIds);

        if (franchisesIds.Count != request.FranchisesIds.Count)
        {
            throw new NotFoundException("One or more franchises were not found.");
        }

        await _modelRepository.AddFranchisesAsync(modelId, franchisesIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Model was updated."
        };
    }
}