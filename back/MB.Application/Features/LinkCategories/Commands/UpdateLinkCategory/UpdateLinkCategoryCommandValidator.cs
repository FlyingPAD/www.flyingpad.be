using FluentValidation;

namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;

public class UpdateLinkCategoryCommandValidator : AbstractValidator<UpdateLinkCategoryCommand>
{
    public UpdateLinkCategoryCommandValidator()
    {
        RuleFor(request => request.Name).NotEmpty().WithMessage("Name is required.");

        RuleFor(request => request.Description).NotEmpty().WithMessage("Description is required.");
    }
}