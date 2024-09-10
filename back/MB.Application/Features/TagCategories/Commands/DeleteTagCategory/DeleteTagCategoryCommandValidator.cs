using FluentValidation;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommandValidator : AbstractValidator<DeleteTagCategoryCommand>
{
    public DeleteTagCategoryCommandValidator()
    {
        RuleFor(request => request.TagCategoryId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
