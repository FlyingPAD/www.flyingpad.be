using MB.Application.Features.Users.Queries.GetLeaderboard;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/v1/leaderboard")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class LeaderboardController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("GetLeaderBoard")]
    public async Task<ActionResult<GetLeaderboardResponse>> Get()
        => Ok(await _mediator.Send(new GetLeaderboardQuery()));
}