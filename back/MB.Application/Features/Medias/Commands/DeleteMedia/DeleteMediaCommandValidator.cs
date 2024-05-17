using FluentValidation;

namespace MB.Application.Features.Medias.Commands.DeleteMedia;

public class DeleteMediaCommandValidator : AbstractValidator<DeleteMediaCommand>
{
    public DeleteMediaCommandValidator()
    {
        RuleFor(x => x.MediaId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
