using MB.Application.Features.Users.Commands.CreateUser;
using MB.Application.Features.Users.Commands.DeleteUser;
using MB.Application.Features.Users.Commands.GainExperience;
using MB.Application.Features.Users.Commands.GainSeasonScore;
using MB.Application.Features.Users.Commands.UnlockAchievement;
using MB.Application.Features.Users.Commands.UnlockAchievements;
using MB.Application.Features.Users.Commands.UpdateUser;
using MB.Application.Features.Users.Queries.CountUsers;
using MB.Application.Features.Users.Queries.GetAllUsers;
using MB.Application.Features.Users.Queries.GetUserAchievements;
using MB.Application.Features.Users.Queries.GetUserById;
using MB.Application.Models;
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
    public async Task<ActionResult<GetAllUsersQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetAllUsersQuery()));

    [HttpGet("GetUser/{userId}")]
    public async Task<ActionResult<GetUserByIdQuery>> GetById( Guid userId )
        => Ok(await _mediator.Send(new GetUserByIdQuery { UserId = userId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateUserCommandResponse>> Update([FromBody] UpdateUserCommand updateUserCommand)
        => Ok(await _mediator.Send(updateUserCommand));

    [HttpDelete("Delete/{userId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<DeleteUserCommandResponse>> Delete(Guid userId)
        => Ok(await _mediator.Send(new DeleteUserCommand { Id = userId }));

    [HttpPost("UnlockAchievement")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> UnlockAchievement([FromBody] UnlockAchievementCommand unlockAchievementCommand)
        => Ok(await _mediator.Send(unlockAchievementCommand));

    [HttpPost("UnlockAchievements")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> UnlockAchievements([FromBody] UnlockAchievementsCommand unlockAchievementsCommand)
    => Ok(await _mediator.Send(unlockAchievementsCommand));

    [HttpPost("GainExperience")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> GainExperience([FromBody] GainExperienceCommand gainExperienceCommand)
        => Ok(await _mediator.Send(gainExperienceCommand));

    [HttpPost("GainSeasonScore")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> GainSeasonScore([FromBody] GainSeasonScoreCommand gainSeasonScoreCommand)
    => Ok(await _mediator.Send(gainSeasonScoreCommand));

    [HttpGet("{userId:guid}/Achievements")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<GetUserAchievementsQueryResponse>> GetAchievements(Guid userId)
        => Ok(await _mediator.Send(new GetUserAchievementsQuery { UserId = userId }));
}