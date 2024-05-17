using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsLinkCategory;

public class CreateRelationsLinkCategoryCommandValidator : AbstractValidator<CreateRelationsLinkCategoryCommand>
{
    public CreateRelationsLinkCategoryCommandValidator()
    {
        RuleFor(command => command.LinkId)
            .NotEmpty().WithMessage("Link ID must not be empty.");

        RuleFor(command => command.CategoryIds)
            .NotEmpty().WithMessage("List must not be empty.")
            .Must(categoryIds => categoryIds.All(categoryId => categoryId != Guid.Empty))
            .WithMessage("One or more invalid ID(s).");
    }
}
