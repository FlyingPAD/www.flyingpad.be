using MB.Application.Features.Medias.Commands.CreateMedia;
using MB.Application.Features.Medias.Commands.DeleteMedia;
using MB.Application.Features.Medias.Commands.UpdateMedia;
using MB.Application.Features.Medias.Queries.CountMedias;
using MB.Application.Features.Medias.Queries.GetMediaById;
using MB.Application.Features.Medias.Queries.GetMediasList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Medias")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class MediasControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMediaCommandResponse>> Create([FromBody] CreateMediaCommand createMediaCommand)
        => Ok(await _mediator.Send(createMediaCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountMediasQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountMediasQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetMediasListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetMediasListQuery()));

    [HttpGet("GetOneDetails/{mediaId}")]
    public async Task<ActionResult<GetMediaByIdQuery>> GetOne(Guid mediaId)
        => Ok(await _mediator.Send(new GetMediaByIdQuery { MediaId = mediaId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateMediaCommandResponse>> Update([FromBody] UpdateMediaCommand updateMediaCommand)
        => Ok(await _mediator.Send(updateMediaCommand));

    [HttpDelete("Delete/{mediaId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<DeleteMediaCommandResponse>> Delete(Guid mediaId)
        => Ok(await _mediator.Send(new DeleteMediaCommand { MediaId = mediaId }));
}