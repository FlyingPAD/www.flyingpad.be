using FluentValidation;

namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory
{
    public class UpdateTagCategoryCommandValidator : AbstractValidator<UpdateTagCategoryCommand>
    {
        public UpdateTagCategoryCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
        }
    }
}
