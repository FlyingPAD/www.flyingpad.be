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

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateUserCommandResponse>> Create([FromBody] CreateUserCommand createUserCommand)
        => Ok(await _mediator.Send(createUserCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountUsersQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountUsersQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetUsersListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetUsersListQuery()));

    [HttpGet("GetOneDetails/{userId}")]
    public async Task<ActionResult<GetUserByIdQuery>> GetOneDetails( Guid userId )
        => Ok(await _mediator.Send(new GetUserByIdQuery { UserId = userId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateUserCommandResponse>> Update([FromBody] UpdateUserCommand updateUserCommand)
        => Ok(await _mediator.Send(updateUserCommand));

    [HttpDelete("Delete/{userId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<DeleteUserCommandResponse>> Delete(Guid userId)
        => Ok(await _mediator.Send(new DeleteUserCommand { Id = userId }));
}