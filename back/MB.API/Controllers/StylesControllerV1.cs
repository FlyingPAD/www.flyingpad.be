using MB.Application.Features.Styles.Commands.CreateStyle;
using MB.Application.Features.Styles.Commands.DeleteStyle;
using MB.Application.Features.Styles.Commands.UpdateStyle;
using MB.Application.Features.Styles.Queries.CountStyles;
using MB.Application.Features.Styles.Queries.GetStyleById;
using MB.Application.Features.Styles.Queries.GetStylesCheck;
using MB.Application.Features.Styles.Queries.GetStylesList;
using MB.Application.Responses;
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

    /// <summary>
    /// Create
    /// </summary>
    [HttpPost("Create")]
    public async Task<ActionResult<CreateStyleCommandResponse>> Create([FromBody] CreateStyleCommand createStyleCommand)
    {
        var response = await _mediator.Send(createStyleCommand);
        return Ok(response);
    }

    /// <summary>
    /// Count
    /// </summary>
    [HttpGet("Count")]
    public async Task<ActionResult<CountStylesQueryResponse>> Count()
    {
        var response = await _mediator.Send(new CountStylesQuery());
        return Ok(response);
    }

    /// <summary>
    /// Get All
    /// </summary>
    [HttpGet("GetAll")]
    public async Task<ActionResult<GetStylesListQueryResponse>> GetAll()
    {
        var response = await _mediator.Send(new GetStylesListQuery());
        return Ok(response);
    }

    /// <summary>
    /// Get One
    /// </summary>
    [HttpGet("GetOneDetails/{styleId}")]
    public async Task<ActionResult<GetStyleByIdQuery>> GetOneDetails(Guid styleId)
    {
        var response = await _mediator.Send(new GetStyleByIdQuery { Id = styleId });
        return Ok(response);
    }

    /// <summary>
    /// Get to Check
    /// </summary>
    [HttpGet("Check/{artistId}")]
    public async Task<ActionResult<GetStylesCheckQueryResponse>> ToCheck(Guid artistId)
    {
        var response = await _mediator.Send(new GetStylesCheckQuery { ArtistId = artistId });
        return Ok(response);
    }

    /// <summary>
    /// Update
    /// </summary>
    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateStyleCommand updateStyleCommand)
    {
        var response = await _mediator.Send(updateStyleCommand);
        return Ok(response);
    }

    /// <summary>
    /// Delete
    /// </summary>
    [HttpDelete("Delete/{styleId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid styleId)
    {
        var response = await _mediator.Send(new DeleteStyleCommand { StyleId = styleId });
        return Ok(response);
    }
}