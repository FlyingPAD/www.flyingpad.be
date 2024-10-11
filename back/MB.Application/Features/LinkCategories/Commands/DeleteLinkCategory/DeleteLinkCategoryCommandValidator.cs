using FluentValidation;

namespace MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;

public class DeleteLinkCategoryCommandValidator : AbstractValidator<DeleteLinkCategoryCommand>
{
    public DeleteLinkCategoryCommandValidator()
    {
        RuleFor(request => request.LinkCategoryId)
            .NotEmpty().WithMessage("LinkCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("LinkCategoryId must not be empty.");
    }
}