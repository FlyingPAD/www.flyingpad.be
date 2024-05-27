using MB.Application.Features.Links.Queries.CountLinks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Status")]
[ApiController]
[ApiExplorerSettings(GroupName = "system")]
public class StatusController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("Get")]
    public ActionResult<CountLinksQueryResponse> GetStatus()
        => Ok("Online");
}