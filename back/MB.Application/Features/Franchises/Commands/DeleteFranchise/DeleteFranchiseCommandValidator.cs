using FluentValidation;

namespace MB.Application.Features.Franchises.Commands.DeleteFranchise;

public class DeleteFranchiseCommandValidator : AbstractValidator<DeleteFranchiseCommand>
{
    public DeleteFranchiseCommandValidator()
    {
        RuleFor(request => request.FranchiseId)
            .NotEmpty().WithMessage("Franchise ID is required.")
            .NotEqual(Guid.Empty).WithMessage("Franchise ID must not be empty.");
    }
}