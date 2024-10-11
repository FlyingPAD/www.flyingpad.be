using FluentValidation;

namespace MB.Application.Features.Styles.Commands.UpdateStyle;

public class UpdateStyleCommandValidator : AbstractValidator<UpdateStyleCommand>
{
    public UpdateStyleCommandValidator()
    {
        RuleFor(request => request.StyleId)
            .NotEmpty().WithMessage("StyleId is required.")
            .Must(id => id != Guid.Empty).WithMessage("StyleId must be a valid GUID.");

        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(2, 30).WithMessage("Name must be between 2 and 30 characters.");
    }
}