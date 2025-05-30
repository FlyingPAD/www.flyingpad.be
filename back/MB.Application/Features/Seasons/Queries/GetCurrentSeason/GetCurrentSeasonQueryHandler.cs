using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Seasons.Queries.GetCurrentSeason;

public class GetCurrentSeasonQueryHandler(ISeasonRepository seasonRepo) : IRequestHandler<GetCurrentSeasonQuery, GetCurrentSeasonQueryResponse>
{
    private readonly ISeasonRepository _seasonRepo = seasonRepo;

    public async Task<GetCurrentSeasonQueryResponse> Handle(GetCurrentSeasonQuery request, CancellationToken cancellationToken)
    {
        var season = await _seasonRepo.GetCurrentSeasonAsync(DateTime.UtcNow).ConfigureAwait(false)
            ?? throw new NotFoundException("Season not found");

        return new GetCurrentSeasonQueryResponse
        {
            Success = true,
            Message = "Saison courante récupérée avec succès",
            CurrentSeason = new GetCurrentSeasonQueryDto
            {
                Name = season.Name,
                StartsAt = season.StartsAt,
                EndsAt = season.EndsAt,
            }
        };
    }
}