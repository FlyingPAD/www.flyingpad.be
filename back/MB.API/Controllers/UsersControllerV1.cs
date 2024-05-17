using MB.Application.Features.Users.Commands.CreateUser;
using MB.Application.Features.Users.Commands.DeleteUser;
using MB.Application.Features.Users.Commands.UpdateUser;
using MB.Application.Features.Users.Queries.CountUsers;
using MB.Application.Features.Users.Queries.GetUserById;
using MB.Application.Features.Users.Queries.GetUsersList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Users")]
[ApiController]
[ApiExplorerSettings(GroupName = "system")]
public class UsersControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    /// <summary>
    /// Create
    /// </summary>
    [HttpPost]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateUserCommandResponse>> CreateUser([FromBody] CreateUserCommand createUserCommand)
    {
        var response = await _mediator.Send(createUserCommand);
        return Ok(response);
    }

    /// <summary>
    /// Count
    /// </summary>
    [HttpGet("Count")]
    public async Task<ActionResult<CountUsersQueryResponse>> Count()
    {
        var response = await _mediator.Send(new CountUsersQuery());
        return Ok(response);
    }

    /// <summary>
    /// Get All
    /// </summary>
    [HttpGet("GetAll")]
    public async Task<ActionResult<GetUsersListQueryResponse>> GetAll()
    {
        var response = await _mediator.Send(new GetUsersListQuery());
        return Ok(response);
    }

    /// <summary>
    /// Get One Details
    /// </summary>
    [HttpGet("GetOneDetails/{userId}")]
    public async Task<ActionResult<GetUserByIdQuery>> GetOneDetails( Guid userId )
    {
        var response = await _mediator.Send(new GetUserByIdQuery { Id = userId });
        return Ok(response);
    }

    /// <summary>
    /// Update
    /// </summary>
    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateUserCommandResponse>> Update([FromBody] UpdateUserCommand updateUserCommand)
    {
        var response = await _mediator.Send(updateUserCommand);
        return Ok(response);
    }

    /// <summary>
    /// Delete
    /// </summary>
    [HttpDelete("Delete/{userId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<DeleteUserCommandResponse>> Delete(Guid userId)
        => Ok(await _mediator.Send(new DeleteUserCommand { Id = userId }));
}