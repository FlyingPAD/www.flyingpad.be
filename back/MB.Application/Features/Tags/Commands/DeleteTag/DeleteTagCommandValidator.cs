using FluentValidation;

namespace MB.Application.Features.Tags.Commands.DeleteTag;

public class DeleteTagCommandValidator : AbstractValidator<DeleteTagCommand>
{
    public DeleteTagCommandValidator()
    {
        RuleFor(request => request.TagId)
            .NotEmpty().WithMessage("TagId is required.")
            .NotEqual(Guid.Empty).WithMessage("TagId must not be empty.");
    }
}