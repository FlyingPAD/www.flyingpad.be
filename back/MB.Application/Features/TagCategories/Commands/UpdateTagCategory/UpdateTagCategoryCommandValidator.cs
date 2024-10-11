using FluentValidation;

namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory;

public class UpdateTagCategoryCommandValidator : AbstractValidator<UpdateTagCategoryCommand>
{
    public UpdateTagCategoryCommandValidator()
    {
        RuleFor(request => request.TagCategoryId)
            .NotEmpty().WithMessage("TagCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("TagCategoryId must not be empty.");

        RuleFor(request => request.Name)
            .NotNull()
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Description)
            .NotNull()
            .NotEmpty().WithMessage("Description is required.")
            .MaximumLength(100).WithMessage("Description must not exceed 100 characters.");
    }
}