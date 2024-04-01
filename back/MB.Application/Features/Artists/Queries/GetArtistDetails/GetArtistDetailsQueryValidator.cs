using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistDetails
{
    public class GetArtistDetailsQueryValidator : AbstractValidator<GetArtistDetailsQuery>
    {
        public GetArtistDetailsQueryValidator()
        {
            RuleFor(x => x.ArtistId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
