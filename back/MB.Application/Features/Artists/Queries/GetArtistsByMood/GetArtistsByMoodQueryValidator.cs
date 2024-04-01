using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistsByMood
{
    public class GetArtistsByMoodQueryValidator : AbstractValidator<GetArtistsByMoodQuery>
    {
        public GetArtistsByMoodQueryValidator()
        {
            RuleFor(x => x.BusinessId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
