using FluentValidation;

namespace MB.Application.Features.Links.Queries.GetLinksByArtist
{
    public class GetLinksByArtistQueryValidator : AbstractValidator<GetLinksByArtistQuery>
    {
        public GetLinksByArtistQueryValidator()
        {
            RuleFor(request => request.ArtistId)
                .NotEmpty().WithMessage("ArtistId is required.")
                .NotEqual(Guid.Empty).WithMessage("ArtistId must not be empty.");
        }
    }
}