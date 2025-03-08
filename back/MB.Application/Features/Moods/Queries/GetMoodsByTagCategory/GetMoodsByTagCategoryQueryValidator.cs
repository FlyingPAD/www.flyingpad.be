using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTagCategory;

public class GetMoodsByTagCategoryQueryValidator : AbstractValidator<GetMoodsByTagCategoryQuery>
{
    public GetMoodsByTagCategoryQueryValidator()
    {
        RuleFor(request => request.TagCategoryId)
            .NotEmpty().WithMessage("TagCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("TagCategoryId must not be empty.");
    }
}