using MB.Application.Responses;

namespace MB.Application.Features.Users.Commands.CreateUser;

public class CreateUserCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateUserDto User { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateUserCommandResponse() : base()
    {

    }
}
