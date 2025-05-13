using MB.Application.Features.Leagues.Queries.GetLeagueByName;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Leagues")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class LeaguesControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("GetLeagueByName/{leagueName}")]
    public async Task<ActionResult<GetLeagueByNameQueryResponse>> GetLeagueByName(string leagueName)
        => Ok(await _mediator.Send(new GetLeagueByNameQuery { Name = leagueName }));
}