using FluentValidation;

namespace MB.Application.Features.Medias.Commands.DeleteMedium;

public class DeleteMediumCommandValidator : AbstractValidator<DeleteMediumCommand>
{
    public DeleteMediumCommandValidator()
    {
        RuleFor(request => request.MediumId)
            .NotEmpty().WithMessage("MediumId is required.")
            .NotEqual(Guid.Empty).WithMessage("MediumId must not be empty.");
    }
}