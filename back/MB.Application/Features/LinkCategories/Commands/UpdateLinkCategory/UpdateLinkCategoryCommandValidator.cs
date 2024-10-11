using FluentValidation;

namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;

public class UpdateLinkCategoryCommandValidator : AbstractValidator<UpdateLinkCategoryCommand>
{
    public UpdateLinkCategoryCommandValidator()
    {
        RuleFor(request => request.LinkCategoryId)
            .NotEmpty().WithMessage("LinkCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("LinkCategoryId must not be empty.");

        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");

        RuleFor(request => request.Description)
            .NotEmpty().WithMessage("Description is required.")
            .NotNull()
            .MaximumLength(100).WithMessage("Description must not exceed 100 characters.");
    }
}