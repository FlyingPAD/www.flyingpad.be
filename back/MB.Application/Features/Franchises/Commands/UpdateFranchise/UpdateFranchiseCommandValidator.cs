using FluentValidation;

namespace MB.Application.Features.Franchises.Commands.UpdateFranchise;

public class UpdateFranchiseCommandValidator : AbstractValidator<UpdateFranchiseCommand>
{
    public UpdateFranchiseCommandValidator()
    {
        RuleFor(request => request.FranchiseId)
            .NotEmpty().WithMessage("FranchiseId is required.")
            .NotEqual(Guid.Empty).WithMessage("FranchiseId must not be empty.");

        RuleFor(request => request.Name)
            .NotNull()
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Description)
            .NotNull()
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
    }
}