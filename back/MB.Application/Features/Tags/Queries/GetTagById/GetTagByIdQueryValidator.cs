using FluentValidation;

namespace MB.Application.Features.Tags.Queries.GetTagById;

public class GetTagByIdQueryValidator : AbstractValidator<GetTagByIdQuery>
{
    public GetTagByIdQueryValidator()
    {
        RuleFor(request => request.TagId)
            .NotEmpty().WithMessage("TagId is required.")
            .NotEqual(Guid.Empty).WithMessage("TagId must not be empty.");
    }
}