using FluentValidation;

namespace MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;

public class CreateLinkCategoryCommandValidator : AbstractValidator<CreateLinkCategoryCommand>
{
    public CreateLinkCategoryCommandValidator()
    {
        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");
    }
}