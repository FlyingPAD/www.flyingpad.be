using FluentValidation;

namespace MB.Application.Features.Styles.Commands.UpdateStyle;

public class UpdateStyleCommandValidator : AbstractValidator<UpdateStyleCommand>
{
    public UpdateStyleCommandValidator()
    {
        RuleFor(x => x.BusinessId)
            .NotEmpty().WithMessage("ID is required.")
            .Must(id => id != Guid.Empty).WithMessage("ID must be a valid GUID.");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(2, 100).WithMessage("Name must be between 2 and 100 characters.");
    }
}