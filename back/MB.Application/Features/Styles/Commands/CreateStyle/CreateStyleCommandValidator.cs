using FluentValidation;

namespace MB.Application.Features.Styles.Commands.CreateStyle;

public class CreateStyleCommandValidator : AbstractValidator<CreateStyleCommand>
{
    public CreateStyleCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
    }
}
