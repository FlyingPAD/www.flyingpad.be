using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsLinkCategory;

public class CreateRelationsLinkCategoryCommandValidator : AbstractValidator<CreateRelationsLinkCategoryCommand>
{
    public CreateRelationsLinkCategoryCommandValidator()
    {
        RuleFor(request => request.LinkId)
            .NotEmpty().WithMessage("LinkId must not be empty.");

        RuleFor(request => request.CategoryIds)
            .NotEmpty().WithMessage("Link Categories list must not be empty.")
            .Must(categoryIds => categoryIds.All(categoryId => categoryId != Guid.Empty))
            .WithMessage("One or more invalid Id('s).");
    }
}