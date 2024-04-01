using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtist
{
    public class GetArtistQueryValidator : AbstractValidator<GetArtistQuery>
    {
        public GetArtistQueryValidator()
        {
            RuleFor(x => x.ArtistId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}