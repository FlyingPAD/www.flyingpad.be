using FluentValidation;

namespace MB.Application.Features.Franchises.Commands.DeleteFranchise;

public class DeleteFranchiseCommandValidator : AbstractValidator<DeleteFranchiseCommand>
{
    public DeleteFranchiseCommandValidator()
    {
        RuleFor(x => x.FranchiseId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
