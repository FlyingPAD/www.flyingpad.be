using MB.Application;
using MB.Application.Features.Links.Commands.CreateLink;
using MB.Application.Features.Links.Commands.DeleteLink;
using MB.Application.Features.Links.Commands.UpdateLink;
using MB.Application.Features.Links.Queries.CountLinks;
using MB.Application.Features.Links.Queries.GetLinkById;
using MB.Application.Features.Links.Queries.GetLinksContainingAbc;
using MB.Application.Features.Links.Queries.GetLinksList;
using MB.Application.Features.Links.Queries.GetLinksListByCategory;
using MB.Application.Features.Links.Queries.GetPageLinksContainingAbc;
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

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateLinkCommandResponse>> Create([FromBody] CreateLinkCommand createLinkCommand)
        => Ok(await _mediator.Send(createLinkCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountLinksQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountLinksQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetLinksListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetLinksListQuery()));

    [HttpGet("GetOneDetails/{linkId}")]
    public async Task<ActionResult<GetLinkByIdQuery>> GetOneDetails( Guid linkId)
        => Ok(await _mediator.Send(new GetLinkByIdQuery { LinkId = linkId }));

    [HttpGet("GetByCategory/{linkCategoryId}")]
    public async Task<ActionResult<GetLinksListByCategoryQueryResponse>> GetByCategory(Guid linkCategoryId)
        => Ok(await _mediator.Send(new GetLinksListByCategoryQuery { LinkCategoryId = linkCategoryId }));

    [HttpGet("GetContaining/{abc}")]
    public async Task<ActionResult<GetLinksContainingAbcQueryResponse>> GetContaining(string? abc)
        => Ok(await _mediator.Send(new GetLinksContainingAbcQuery { Abc = abc }));

    [HttpGet("GetPageContaining")]
    public async Task<ActionResult<GetPageLinksContainingAbcQueryResponse>> GetPageContaining(Guid startId, string? abc = "", int pageSize = 10, bool isFirstItem = false)
        => Ok(await _mediator.Send(new GetPageLinksContainingAbcQuery { Abc = abc, StartId = startId, PageSize = pageSize, IsFirstItem = isFirstItem }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> UpdateLink([FromBody] UpdateLinkCommand updateLinkCommand)
        => Ok(await _mediator.Send(updateLinkCommand));

    [HttpDelete("Delete/{linkId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid linkId)
        => Ok(await _mediator.Send(new DeleteLinkCommand { LinkId = linkId }));
}