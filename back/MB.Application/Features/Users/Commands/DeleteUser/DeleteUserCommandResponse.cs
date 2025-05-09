﻿using MB.Application.Models;

namespace MB.Application.Features.Users.Commands.DeleteUser;

public class DeleteUserCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public DeleteUserCommandDto DeletedUserId { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public DeleteUserCommandResponse() : base()
    {

    }
}
