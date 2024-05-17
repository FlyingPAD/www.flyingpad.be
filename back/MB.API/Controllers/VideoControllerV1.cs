using MB.Application.Features.Videos.Queries.GetOneVideoDetailsQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Videos")]
[ApiController]
[ApiExplorerSettings(GroupName = "extensions")]
public class VideoControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    ///<summary>
    /// Get One Details
    /// </summary>
    [HttpGet("GetOneDetails/{videoId}")]
    public async Task<ActionResult<GetOneVideoDetailsQueryResponse>> GetOneDetails(Guid videoId)
        => Ok(await _mediator.Send(new GetOneVideoDetailsQuery { VideoId = videoId }));
}