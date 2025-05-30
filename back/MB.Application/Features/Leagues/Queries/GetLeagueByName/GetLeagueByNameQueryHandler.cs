using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Leagues.Queries.GetLeagueByName;

public class GetLeagueByNameQueryHandler(ILeagueDefinitionsRepository leagueRepo, IUserRepository userRepo) : IRequestHandler<GetLeagueByNameQuery, GetLeagueByNameQueryResponse>
{
    private readonly ILeagueDefinitionsRepository _leagueRepo = leagueRepo;
    private readonly IUserRepository _userRepo = userRepo;

    public async Task<GetLeagueByNameQueryResponse> Handle(GetLeagueByNameQuery request, CancellationToken cancellationToken)
    {
        var response = new GetLeagueByNameQueryResponse();

        if (string.IsNullOrWhiteSpace(request.Name))
        {
            response.Success = false;
            response.Message = "Le nom de la ligue est requis.";
            return response;
        }

        var league = await _leagueRepo.GetByNameAsync(request.Name, cancellationToken);
        if (league is null)
        {
            response.Success = false;
            response.Message = $"La ligue '{request.Name}' est introuvable.";
            return response;
        }

        var members = await _userRepo.GetByLeagueDefinitionIdAsync(
            league.EntityId, cancellationToken);

        var memberDtos = members
            .Select(u => new LeagueMemberDto
            {
                BusinessId = u.BusinessId,
                UserName = u.UserName ?? "[inconnu]",
                SeasonScore = u.SeasonScore
            })
            .ToList();

        response.Success = true;
        response.Message = "Ligue récupérée avec succès.";
        response.League = new LeagueWithRankingDto
        {
            BusinessId = league.BusinessId,
            LeagueName = league.Name,
            MinExperience = league.MinExperience,
            MaxExperience = league.MaxExperience,
            IconCssClass = league.IconCssClass,
            Order = league.Order,
            Members = memberDtos
        };

        return response;
    }
}