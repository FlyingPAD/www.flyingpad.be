using FluentValidation;

namespace MB.Application.Features.Links.Commands.DeleteLink;

public class DeleteLinkCommandValidator : AbstractValidator<DeleteLinkCommand>
{
    public DeleteLinkCommandValidator()
    {
        RuleFor(x => x.LinkId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}