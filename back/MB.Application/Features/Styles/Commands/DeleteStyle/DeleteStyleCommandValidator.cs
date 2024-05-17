using FluentValidation;

namespace MB.Application.Features.Styles.Commands.DeleteStyle;

public class DeleteStyleCommandValidator : AbstractValidator<DeleteStyleCommand>
{
    public DeleteStyleCommandValidator()
    {
        RuleFor(x => x.StyleId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
