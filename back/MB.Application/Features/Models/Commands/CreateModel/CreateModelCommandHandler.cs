using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Commands.CreateModel;

public class CreateModelCommandHandler(IModelRepository modelRepository, IFranchiseRepository franchiseRepository) : IRequestHandler<CreateModelCommand, CreateModelCommandResponse>
{
    private readonly IModelRepository _modelRepository = modelRepository;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;

    public async Task<CreateModelCommandResponse> Handle(CreateModelCommand request, CancellationToken cancellationToken)
    {
        var model = new Model
        {
            Pseudonym = request.Pseudonym,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Gender = request.Gender,
            Description = request.Description,
        };

        model = await _modelRepository.CreateAsync(model);

        var franchisesIds = await _franchiseRepository.GetPrimaryIdsByBusinessIdsAsync(request.FranchisesIds);

        if (franchisesIds.Count != request.FranchisesIds.Count)
        {
            throw new NotFoundException("One or more franchises were not found.");
        }

        await _modelRepository.AddFranchisesAsync(model.EntityId, franchisesIds);

        return new CreateModelCommandResponse
        {
            Success = true,
            Message = "Model was created.",
            ModelId = model.BusinessId
        };
    }
}