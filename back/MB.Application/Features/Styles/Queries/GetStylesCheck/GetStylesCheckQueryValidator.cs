using FluentValidation;

namespace MB.Application.Features.Styles.Queries.GetStylesCheck
{
    public class GetStylesCheckQueryValidator : AbstractValidator<GetStylesCheckQuery>
    {
        public GetStylesCheckQueryValidator()
        {
            RuleFor(query => query.ArtistId)
                .NotEmpty().WithMessage("The artist ID must not be empty.")
                .NotEqual(Guid.Empty).WithMessage("The provided artist ID is invalid.");
        }
    }
}