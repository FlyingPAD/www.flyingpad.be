using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsModelFranchise;

public class CreateRelationsModelFranchiseCommandValidator : AbstractValidator<CreateRelationsModelFranchiseCommand>
{
    public CreateRelationsModelFranchiseCommandValidator()
    {
        RuleFor(request => request.ModelId)
            .NotEmpty().WithMessage("ModelId must not be empty.");

        RuleFor(request => request.FranchiseIds)
            .NotEmpty().WithMessage("Franchises list must not be empty.")
            .Must(franchiseIds => franchiseIds.All(franchiseId => franchiseId != Guid.Empty))
            .WithMessage("One or more invalid Id('s).");
    }
}
