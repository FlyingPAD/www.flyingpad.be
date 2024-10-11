using MB.Application.Features.Medias.Commands.CreateMedium;
using MB.Application.Features.Medias.Commands.DeleteMedium;
using MB.Application.Features.Medias.Commands.UpdateMedium;
using MB.Application.Features.Medias.Queries.CountMedia;
using MB.Application.Features.Medias.Queries.GetAllMedia;
using MB.Application.Features.Medias.Queries.GetMediaCheckBoxesByFranchise;
using MB.Application.Features.Medias.Queries.GetMediumById;
using MB.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Media")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class MediaControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMediumCommandResponse>> Create([FromBody] CreateMediumCommand createMediumCommand)
        => Ok(await _mediator.Send(createMediumCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountMediaQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountMediaQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetAllMediaQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetAllMediaQuery()));

    [HttpGet("GetOneDetails/{mediumId}")]
    public async Task<ActionResult<GetMediumByIdQuery>> GetById(Guid mediumId)
        => Ok(await _mediator.Send(new GetMediumByIdQuery { MediumId = mediumId }));

    [HttpGet("GetCheckBoxesByFranchise/{franchiseId}")]
    public async Task<ActionResult<GetMediaCheckBoxesByFranchiseQueryResponse>> GetCheckBoxesByFranchise(Guid franchiseId)
    => Ok(await _mediator.Send(new GetMediaCheckBoxesByFranchiseQuery { FranchiseId = franchiseId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateMediumCommand updateMediumCommand)
        => Ok(await _mediator.Send(updateMediumCommand));

    [HttpDelete("Delete/{mediumId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid mediumId)
        => Ok(await _mediator.Send(new DeleteMediumCommand { MediumId = mediumId }));
}