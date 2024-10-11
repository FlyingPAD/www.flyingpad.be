using FluentValidation;

namespace MB.Application.Features.Franchises.Commands.DeleteFranchise;

public class DeleteFranchiseCommandValidator : AbstractValidator<DeleteFranchiseCommand>
{
    public DeleteFranchiseCommandValidator()
    {
        RuleFor(request => request.FranchiseId)
            .NotEmpty().WithMessage("FranchiseId is required.")
            .NotEqual(Guid.Empty).WithMessage("FranchiseId must not be empty.");
    }
}