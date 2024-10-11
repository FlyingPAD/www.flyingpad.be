using FluentValidation;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommandValidator : AbstractValidator<DeleteTagCategoryCommand>
{
    public DeleteTagCategoryCommandValidator()
    {
        RuleFor(request => request.TagCategoryId)
            .NotEmpty().WithMessage("TagCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("TagCategoryId must not be empty.");
    }
}