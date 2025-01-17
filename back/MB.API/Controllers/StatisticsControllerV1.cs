using MB.Application.Features.Artists.Queries.GetArtistById;
using MB.Application.Features.Statistics.Queries.GetStatistics;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;
[Route("api/V1/Statistics")]
[ApiController]
[ApiExplorerSettings(GroupName = "system")]
public class StatisticsControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("GetStatistics")]
    public async Task<ActionResult<GetStatisticsQuery>> GetStatistics()
        => Ok(await _mediator.Send( new GetStatisticsQuery() ));
}