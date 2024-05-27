using MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;
using MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;
using MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;
using MB.Application.Features.LinkCategories.Queries.CountLinkCategories;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MB.API.Controllers;

[Route("api/V1/LinkCategories")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class LinkCategoriesControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateLinkCategoryCommandResponse>> Create([FromBody] CreateLinkCategoryCommand createLinkCategoryCommand)
        => Ok(await _mediator.Send(createLinkCategoryCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountLinkCategoriesQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountLinkCategoriesQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetLinkCategoriesListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetLinkCategoriesListQuery()));

    [HttpGet("GetOneDetails/{linkCategoryId}")]
    public async Task<ActionResult<GetLinkCategoryByIdQueryResponse>> GetOneDetails( Guid linkCategoryId)
        => Ok(await _mediator.Send(new GetLinkCategoryByIdQuery { LinkCategoryId = linkCategoryId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateLinkCategoryCommandResponse>> Update([FromBody] UpdateLinkCategoryCommand updateLinkCategoryCommand)
        => Ok(await _mediator.Send(updateLinkCategoryCommand));

    [HttpDelete("Delete/{linkCategoryId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<DeleteLinkCategoryCommandResponse>> Delete( Guid linkCategoryId )
        => Ok(await _mediator.Send(new DeleteLinkCategoryCommand { LinkCategoryId = linkCategoryId }));
}