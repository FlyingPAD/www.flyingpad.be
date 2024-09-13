using FluentValidation;

namespace MB.Application.Features.Tags.Commands.CreateTag;

public class CreateTagCommandValidator : AbstractValidator<CreateTagCommand>
{
    public CreateTagCommandValidator()
    {
        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Description)
            .MaximumLength(200).WithMessage("Description must not exceed 150 characters.");

        RuleFor(request => request.TagCategoryId)
            .NotEqual(Guid.Empty).WithMessage("TagCategoryId must not be empty.");
    }
}