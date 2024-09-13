using MB.Application.Features.Videos.Queries.GetOneVideoDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Videos")]
[ApiController]
[ApiExplorerSettings(GroupName = "extensions")]
public class VideoControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("GetOneDetails/{videoId}")]
    public async Task<ActionResult<GetOneVideoDetailsQueryResponse>> GetOneDetails(Guid videoId)
        => Ok(await _mediator.Send(new GetOneVideoDetailsQuery { VideoId = videoId }));
}