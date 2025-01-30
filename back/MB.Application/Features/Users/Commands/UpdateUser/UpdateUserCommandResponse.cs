using MB.Application.Models;

namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandResponse : BaseResponse
{
    public UpdateUserDto UpdatedUser { get; set; } = default!;
}