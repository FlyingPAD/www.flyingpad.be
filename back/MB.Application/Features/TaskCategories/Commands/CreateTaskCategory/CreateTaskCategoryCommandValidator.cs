using FluentValidation;

namespace MB.Application.Features.TaskCategories.Commands.CreateTaskCategory;

public class CreateTaskCategoryCommandValidator : AbstractValidator<CreateTaskCategoryCommand>
{
    public CreateTaskCategoryCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
    }
}
