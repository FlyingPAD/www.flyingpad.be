using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistById;

public class GetArtistByIdQueryValidator : AbstractValidator<GetArtistByIdQuery>
{
    public GetArtistByIdQueryValidator()
    {
        RuleFor(x => x.ArtistId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}