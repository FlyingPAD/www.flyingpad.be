using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistsByStyle
{
    public class GetArtistsByStyleQueryValidator : AbstractValidator<GetArtistsByStyleQuery>
    {
        public GetArtistsByStyleQueryValidator()
        {
            RuleFor(x => x.BusinessId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
