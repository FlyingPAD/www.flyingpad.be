using MediatR;

namespace MB.Application.Features.Users.Queries.GetUserAchievements;

public class GetUserAchievementsQuery : IRequest<GetUserAchievementsQueryResponse>
{
    public Guid UserId { get; init; }
}