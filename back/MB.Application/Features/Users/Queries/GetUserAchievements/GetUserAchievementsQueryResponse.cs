using MB.Application.Models;

namespace MB.Application.Features.Users.Queries.GetUserAchievements;

public class GetUserAchievementsQueryResponse : BaseResponse
{
    public List<GetUserAchievementsQueryDto> Achievements { get; set; } = [];
}