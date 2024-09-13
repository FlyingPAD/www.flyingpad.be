using FluentValidation;

namespace MB.Application.Features.Tags.Commands.UpdateTag;

public class UpdateTagCommandValidator : AbstractValidator<UpdateTagCommand>
{
    public UpdateTagCommandValidator()
    {
        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Description)
            .MaximumLength(200).WithMessage("Description must not exceed 150 characters.");

        RuleFor(request => request.TagId)
            .NotEqual(Guid.Empty).WithMessage("TagId must not be empty.");

        RuleFor(request => request.TagCategoryId)
            .NotEqual(Guid.Empty).WithMessage("TagCategoryId must not be empty.");
    }
}