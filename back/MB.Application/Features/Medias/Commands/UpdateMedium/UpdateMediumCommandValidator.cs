using FluentValidation;

namespace MB.Application.Features.Medias.Commands.UpdateMedium;

public class UpdateMediumCommandValidator : AbstractValidator<UpdateMediumCommand>
{
    public UpdateMediumCommandValidator()
    {
        RuleFor(request => request.MediumId)
            .NotEmpty().WithMessage("MediumId is required.")
            .NotEqual(Guid.Empty).WithMessage("MediumId must not be empty.");

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