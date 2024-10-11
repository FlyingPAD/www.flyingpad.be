using FluentValidation;

namespace MB.Application.Features.Medias.Commands.CreateMedium;

public class CreateMediumCommandValidator : AbstractValidator<CreateMediumCommand>
{
    public CreateMediumCommandValidator()
    {
        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Description)
            .NotEmpty().WithMessage("Description is required.")
            .NotNull()
            .MaximumLength(100).WithMessage("Description must not exceed 100 characters.");
    }
}