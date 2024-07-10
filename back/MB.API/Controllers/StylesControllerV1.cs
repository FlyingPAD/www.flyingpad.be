using MB.Application;
using MB.Application.Features.Styles.Commands.CreateStyle;
using MB.Application.Features.Styles.Commands.DeleteStyle;
using MB.Application.Features.Styles.Commands.UpdateStyle;
using MB.Application.Features.Styles.Queries.CountStyles;
using MB.Application.Features.Styles.Queries.GetStyleById;
using MB.Application.Features.Styles.Queries.GetStylesCheck;
using MB.Application.Features.Styles.Queries.GetStylesList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Styles")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class StylesControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    public async Task<ActionResult<CreateStyleCommandResponse>> Create([FromBody] CreateStyleCommand createStyleCommand)
        => Ok(await _mediator.Send(createStyleCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountStylesQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountStylesQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetStylesListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetStylesListQuery()));

    [HttpGet("GetOneDetails/{styleId}")]
    public async Task<ActionResult<GetStyleByIdQuery>> GetOneDetails(Guid styleId)
        => Ok(await _mediator.Send(new GetStyleByIdQuery { Id = styleId }));

    [HttpGet("Check/{artistId}")]
    public async Task<ActionResult<GetStylesCheckQueryResponse>> ToCheck(Guid artistId)
        => Ok(await _mediator.Send(new GetStylesCheckQuery { ArtistId = artistId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateStyleCommand updateStyleCommand)
        => Ok(await _mediator.Send(updateStyleCommand));

    [HttpDelete("Delete/{styleId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid styleId)
        => Ok(await _mediator.Send(new DeleteStyleCommand { StyleId = styleId }));
}