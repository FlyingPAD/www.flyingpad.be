namespace MB.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public UpdateUserDto UpdatedUser { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public UpdateUserCommandResponse() : base()
    {

    }
}
