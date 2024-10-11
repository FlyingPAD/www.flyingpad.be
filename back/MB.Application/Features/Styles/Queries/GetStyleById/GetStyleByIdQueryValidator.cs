using FluentValidation;

namespace MB.Application.Features.Styles.Queries.GetStyleById;

public class GetStyleByIdQueryValidator : AbstractValidator<GetStyleByIdQuery>
{
    public GetStyleByIdQueryValidator()
    {
        RuleFor(request => request.StyleId)
            .NotEmpty().WithMessage("StyleId is required.")
            .NotEqual(Guid.Empty).WithMessage("StyleId must not be empty.");
    }
}