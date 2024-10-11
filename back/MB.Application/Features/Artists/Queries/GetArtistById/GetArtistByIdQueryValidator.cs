using FluentValidation;

namespace MB.Application.Features.Artists.Queries.GetArtistById;

public class GetArtistByIdQueryValidator : AbstractValidator<GetArtistByIdQuery>
{
    public GetArtistByIdQueryValidator()
    {
        RuleFor(request => request.ArtistId)
            .NotEmpty().WithMessage("ArtistId is required.")
            .NotEqual(Guid.Empty).WithMessage("ArtistId must not be empty.");
    }
}