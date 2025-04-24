using MB.Application.Features.AudioSoundCloud.Queries.GetSoundCloudAudioById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/AudioSoundCloud")]
[ApiController]
[ApiExplorerSettings(GroupName = "extensions")]
public class AudioSoundCloudControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("GetOneDetails/{audioSoundCloudId}")]
    public async Task<ActionResult<GetSoundCloudAudioByIdQueryResponse>> GetOneDetails(Guid audioSoundCloudId)
        => Ok(await _mediator.Send(new GetSoundCloudAudioByIdQuery { AudioSoundCloudId = audioSoundCloudId }));
}