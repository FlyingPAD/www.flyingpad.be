using FluentValidation;

namespace MB.Application.Features.TagCategories.Commands.CreateTagCategory;

public class CreateTagCategoryCommandValidator : AbstractValidator<CreateTagCategoryCommand>
{
    public CreateTagCategoryCommandValidator()
    {
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