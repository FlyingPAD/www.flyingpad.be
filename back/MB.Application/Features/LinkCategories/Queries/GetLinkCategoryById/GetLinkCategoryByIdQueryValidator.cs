using FluentValidation;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;

public class GetLinkCategoryByIdQueryValidator : AbstractValidator<GetLinkCategoryByIdQuery>
{
    public GetLinkCategoryByIdQueryValidator()
    {
        RuleFor(x => x.LinkCategoryId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
