using MB.Application.Models;

namespace MB.Application.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQueryResponse : BaseResponse
{
    public List<GetAllUsersQueryDto> Users { get; set; } = default!;
}