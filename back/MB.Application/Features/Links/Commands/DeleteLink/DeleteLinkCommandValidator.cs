using FluentValidation;

namespace MB.Application.Features.Links.Commands.DeleteLink;

public class DeleteLinkCommandValidator : AbstractValidator<DeleteLinkCommand>
{
    public DeleteLinkCommandValidator()
    {
        RuleFor(request => request.LinkId)
            .NotEmpty().WithMessage("LinkId is required.")
            .NotEqual(Guid.Empty).WithMessage("LinkId must not be empty.");
    }
}