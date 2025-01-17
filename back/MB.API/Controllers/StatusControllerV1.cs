using MB.Application.Features.Links.Queries.CountLinks;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Status")]
[ApiController]
[ApiExplorerSettings(GroupName = "system")]
public class StatusControllerV1() : ControllerBase
{
    [HttpGet("Get")]
    public ActionResult<CountLinksQueryResponse> GetStatus()
        => Ok("Online");
}