using FluentValidation;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;

public class GetLinkCategoryByIdQueryValidator : AbstractValidator<GetLinkCategoryByIdQuery>
{
    public GetLinkCategoryByIdQueryValidator()
    {
        RuleFor(request => request.LinkCategoryId)
            .NotEmpty().WithMessage("LinkCategoryId is required.")
            .NotEqual(Guid.Empty).WithMessage("LinkCategoryId must not be empty.");
    }
}