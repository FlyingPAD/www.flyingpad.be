using MB.Application.Features.Seasons.Queries.GetCurrentSeason;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Seasons")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class SeasonControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("GetCurrentSeason")]
    public async Task<ActionResult<GetCurrentSeasonQueryResponse>> GetCurrentSeasons()
        => Ok(await _mediator.Send(new GetCurrentSeasonQuery {}));
}