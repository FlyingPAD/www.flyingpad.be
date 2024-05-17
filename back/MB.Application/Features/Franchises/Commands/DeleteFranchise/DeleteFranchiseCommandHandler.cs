using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Franchises.Commands.DeleteFranchise;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteFranchiseCommandHandler(IMapper mapper, IBaseRepository<Franchise> franchiseRepository) : IRequestHandler<DeleteFranchiseCommand, DeleteFranchiseCommandResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;

    public async Task<DeleteFranchiseCommandResponse> Handle(DeleteFranchiseCommand request, CancellationToken cancellationToken)
    {
        var deleteFranchiseCommandResponse = new DeleteFranchiseCommandResponse { Success = true };

        var validator = new DeleteFranchiseCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            deleteFranchiseCommandResponse.Success = false;
            deleteFranchiseCommandResponse.ValidationErrors = [];

            foreach (var error in validationResult.Errors)
            {
                deleteFranchiseCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }

        if (deleteFranchiseCommandResponse.Success)
        {
            var franchise = await _franchiseRepository.GetByBusinessIdAsync(request.FranchiseId);

            if (franchise != null)
            {
                await _franchiseRepository.DeleteAsync(franchise);
            }
            else
            {
                deleteFranchiseCommandResponse.Success = false;
                deleteFranchiseCommandResponse.ValidationErrors = ["Selected franchise doesn't exist."];
            }
        }

        return deleteFranchiseCommandResponse;
    }

}