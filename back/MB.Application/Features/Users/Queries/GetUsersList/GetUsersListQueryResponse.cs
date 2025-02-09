using MB.Application.Models;

namespace MB.Application.Features.Users.Queries.GetUsersList;

public class GetUsersListQueryResponse : BaseResponse
{
    public List<GetUsersListQueryDto> UsersList { get; set; } = default!;
}