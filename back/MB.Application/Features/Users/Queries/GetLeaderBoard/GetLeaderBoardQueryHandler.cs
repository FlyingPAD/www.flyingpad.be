using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Users.Queries.GetLeaderboard;

public class GetLeaderboardQueryHandler(IUserRepository userRepo, IMapper mapper) : IRequestHandler<GetLeaderboardQuery, GetLeaderboardResponse>
{
    private readonly IUserRepository _userRepo = userRepo;
    private readonly IMapper _mapper = mapper;

    public async Task<GetLeaderboardResponse> Handle(GetLeaderboardQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepo.GetAllWithLeagueAsync();

        var ordered = users
            .OrderByDescending(u => u.Level)
            .ThenByDescending(u => u.SeasonScore)
            .ThenByDescending(u => u.Experience)
            .ToList();

        var entries = ordered.Select(u => new LeaderboardEntryDto
        {
            BusinessId = u.BusinessId.ToString(),
            UserName = u.UserName ?? "-",
            Level = u.Level,
            Experience = u.Experience,
            SeasonScore = u.SeasonScore,
            LeagueName = u.LeagueDefinition?.Name ?? "—"
        }).ToList();

        return new GetLeaderboardResponse
        {
            Success = true,
            Message = "Ladder was generated.",
            Entries = entries
        };
    }
}