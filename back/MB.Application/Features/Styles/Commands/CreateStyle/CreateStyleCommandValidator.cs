using FluentValidation;

namespace MB.Application.Features.Styles.Commands.CreateStyle;

public class CreateStyleCommandValidator : AbstractValidator<CreateStyleCommand>
{
    public CreateStyleCommandValidator()
    {
        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Description is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("Description must not exceed 50 characters.");
    }
}