using FluentValidation;

namespace MB.Application.Features.TagCategories.Queries.GetTagCategoryById;

public class GetTagCategoryByIdQueryValidator : AbstractValidator<GetTagCategoryByIdQuery>
{
    public GetTagCategoryByIdQueryValidator()
    {
        RuleFor(request => request.TagCategoryId)
            .NotEmpty().WithMessage("TagCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("TagCategoryId must not be empty.");
    }
}