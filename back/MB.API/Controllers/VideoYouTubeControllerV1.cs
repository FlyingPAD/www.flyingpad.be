using MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/VideosYouTube")]
[ApiController]
[ApiExplorerSettings(GroupName = "extensions")]
public class VideoYouTubeControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("GetOneDetails/{videoYouTubeId}")]
    public async Task<ActionResult<GetOneVideoYTDetailsQueryResponse>> GetOneDetails(Guid videoYouTubeId)
        => Ok(await _mediator.Send(new GetOneVideoYTDetailsQuery { VideoYouTubeId = videoYouTubeId }));
}