using FluentValidation;

namespace MB.Application.Features.Tags.Queries.GetTagsByCategory
{
    public class GetTagsByCategoryQueryValidator : AbstractValidator<GetTagsByCategoryQuery>
    {
        public GetTagsByCategoryQueryValidator()
        {
            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}