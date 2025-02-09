using MB.Application.Models;

namespace MB.Application.Features.Users.Queries.CountUsers;

public class CountUsersQueryResponse : BaseResponse
{
    public int UsersCount { get; set; }
}