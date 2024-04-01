using FluentValidation;

namespace MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory
{
    public class DeleteLinkCategoryCommandValidator : AbstractValidator<DeleteLinkCategoryCommand>
    {
        public DeleteLinkCategoryCommandValidator()
        {
            RuleFor(x => x.LinkCategoryId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
