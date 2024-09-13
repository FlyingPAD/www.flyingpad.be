using FluentValidation;

namespace MB.Application.Features.Tags.Queries.GetTagsByCategory;

public class GetTagsByCategoryQueryValidator : AbstractValidator<GetTagsByCategoryQuery>
{
    public GetTagsByCategoryQueryValidator()
    {
        RuleFor(request => request.CategoryId)
            .NotEmpty().WithMessage("TagCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("TagCategoryId must not be empty.");
    }
}