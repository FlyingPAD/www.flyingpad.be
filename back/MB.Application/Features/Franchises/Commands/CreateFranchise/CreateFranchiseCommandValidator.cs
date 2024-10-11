using FluentValidation;

namespace MB.Application.Features.Franchises.Commands.CreateFranchise;

public class CreateFranchiseCommandValidator : AbstractValidator<CreateFranchiseCommand>
{
    public CreateFranchiseCommandValidator()
    {
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