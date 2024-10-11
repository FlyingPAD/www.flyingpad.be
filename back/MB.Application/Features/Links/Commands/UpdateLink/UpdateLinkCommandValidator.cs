using FluentValidation;

namespace MB.Application.Features.Links.Commands.UpdateLink;

public class UpdateLinkCommandValidator : AbstractValidator<UpdateLinkCommand>
{
    public UpdateLinkCommandValidator()
    {
        RuleFor(request => request.LinkId)
            .NotEmpty().WithMessage("LinkId is required.")
            .NotEqual(Guid.Empty).WithMessage("LinkId must not be empty.");

        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Description)
            .NotEmpty().WithMessage("Description is required.")
            .NotNull()
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
    }
}