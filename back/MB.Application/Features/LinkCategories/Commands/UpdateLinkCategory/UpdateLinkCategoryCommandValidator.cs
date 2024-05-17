using FluentValidation;

namespace MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;

public class UpdateLinkCategoryCommandValidator : AbstractValidator<UpdateLinkCategoryCommand>
{
    public UpdateLinkCategoryCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
    }
}
