using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsModelFranchise;

public class CreateRelationsModelFranchiseCommandValidator : AbstractValidator<CreateRelationsModelFranchiseCommand>
{
    public CreateRelationsModelFranchiseCommandValidator()
    {
        RuleFor(command => command.ModelId)
            .NotEmpty().WithMessage("Model ID must not be empty.");

        RuleFor(command => command.FranchiseIds)
            .NotEmpty().WithMessage("List must not be empty.")
            .Must(franchiseIds => franchiseIds.All(franchiseId => franchiseId != Guid.Empty))
            .WithMessage("One or more invalid ID(s).");
    }
}
