using MB.Application.Models;

namespace MB.Application.Features.Users.Queries.GetLeaderboard;

public class GetLeaderboardResponse : BaseResponse
{
    public List<LeaderboardEntryDto> Entries { get; set; } = [];
}