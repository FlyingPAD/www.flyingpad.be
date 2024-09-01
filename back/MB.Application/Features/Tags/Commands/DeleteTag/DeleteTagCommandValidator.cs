using FluentValidation;

namespace MB.Application.Features.Tags.Commands.DeleteTag;

public class DeleteTagCommandValidator : AbstractValidator<DeleteTagCommand>
{
    public DeleteTagCommandValidator()
    {
        RuleFor(property => property.TagId)
            .NotEmpty().WithMessage("Tag ID is required.")
            .NotEqual(Guid.Empty).WithMessage("Tag ID must not be empty.");
    }
}
