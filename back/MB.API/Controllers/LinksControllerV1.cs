using MB.Application.Features.Links.Commands.CreateLink;
using MB.Application.Features.Links.Commands.DeleteLink;
using MB.Application.Features.Links.Commands.UpdateLink;
using MB.Application.Features.Links.Queries.CountLinks;
using MB.Application.Features.Links.Queries.GetLinkById;
using MB.Application.Features.Links.Queries.GetLinksContainingAbc;
using MB.Application.Features.Links.Queries.GetLinksList;
using MB.Application.Features.Links.Queries.GetLinksListByCategory;
using MB.Application.Features.Links.Queries.GetPageLinksContainingAbc;
using MB.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Links")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class LinksControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    /// <summary>
    /// Create
    /// </summary>
    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateLinkCommandResponse>> Create([FromBody] CreateLinkCommand createLinkCommand)
        => Ok(await _mediator.Send(createLinkCommand));

    /// <summary>
    /// Count
    /// </summary>
    [HttpGet("Count")]
    public async Task<ActionResult<CountLinksQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountLinksQuery()));

    /// <summary>
    /// Get All
    /// </summary>
    [HttpGet("GetAll")]
    public async Task<ActionResult<GetLinksListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetLinksListQuery()));

    /// <summary>
    /// Get One Details
    /// </summary>
    [HttpGet("GetOneDetails/{linkId}")]
    public async Task<ActionResult<GetLinkByIdQuery>> GetOneDetails( Guid linkId)
    {
        var response = await _mediator.Send(new GetLinkByIdQuery { LinkId = linkId });
        return Ok(response);
    }

    /// <summary>
    /// Get Links By Category ID
    /// </summary>
    [HttpGet("GetByCategory/{linkCategoryId}")]
    public async Task<ActionResult<GetLinksListByCategoryQueryResponse>> GetByCategory(Guid linkCategoryId)
    {
        var response = await _mediator.Send(new GetLinksListByCategoryQuery { LinkCategoryId = linkCategoryId });
        return Ok(response);
    }

    /// <summary>
    /// Get Links Containing ' ABC '
    /// </summary>
    [HttpGet("GetContaining/{abc}")]
    public async Task<ActionResult<GetLinksContainingAbcQueryResponse>> GetContaining(string? abc)
        => Ok(await _mediator.Send(new GetLinksContainingAbcQuery { Abc = abc }));

    /// <summary>
    /// Get Page of Links Containing ' ABC '
    /// </summary>
    [HttpGet("GetPageContaining")]
    public async Task<ActionResult<GetPageLinksContainingAbcQueryResponse>> GetPageContaining(Guid startId, string? abc = "", int pageSize = 10, bool isFirstItem = false)
    {
        var response = await _mediator.Send(new GetPageLinksContainingAbcQuery { Abc = abc, StartId = startId, PageSize = pageSize, IsFirstItem = isFirstItem });
        return Ok(response);
    }

    /// <summary>
    /// Update
    /// </summary>
    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateLinkCommandResponse>> UpdateLink(Guid linkId, [FromBody] UpdateLinkCommand updateLinkCommand)
    {
        if (linkId != updateLinkCommand.Id)
        {
            return BadRequest("ID in the URL does not match ID in the request body.");
        }

        var response = await _mediator.Send(updateLinkCommand);
        return Ok(response);
    }

    /// <summary>
    /// Delete
    /// </summary>
    [HttpDelete("Delete/{linkId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid linkId)
    => Ok(await _mediator.Send(new DeleteLinkCommand { LinkId = linkId }));
}