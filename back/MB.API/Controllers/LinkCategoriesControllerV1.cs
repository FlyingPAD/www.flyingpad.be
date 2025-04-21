using MB.Application;
using MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;
using MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;
using MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;
using MB.Application.Features.LinkCategories.Queries.CountLinkCategories;
using MB.Application.Features.LinkCategories.Queries.GetAllLinkCategories;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/LinkCategories")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class LinkCategoriesControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateLinkCategoryCommandResponse>> Create([FromBody] CreateLinkCategoryCommand createLinkCategoryCommand)
        => Ok(await _mediator.Send(createLinkCategoryCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountLinkCategoriesQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountLinkCategoriesQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetAllLinkCategoriesQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetAllLinkCategoriesQuery()));

    [HttpGet("GetOneDetails/{linkCategoryId}")]
    public async Task<ActionResult<GetLinkCategoryByIdQueryResponse>> GetById(Guid linkCategoryId)
        => Ok(await _mediator.Send(new GetLinkCategoryByIdQuery { LinkCategoryId = linkCategoryId }));

    [HttpGet("GetCheckBoxesByLink/{linkId}")]
    public async Task<ActionResult<GetLinkCategoriesCheckBoxesByLinkQueryResponse>> GetCheckBoxesByLink(Guid linkId)
        => Ok(await _mediator.Send(new GetLinkCategoriesCheckBoxesByLinkQuery { LinkId = linkId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateLinkCategoryCommand updateLinkCategoryCommand)
        => Ok(await _mediator.Send(updateLinkCategoryCommand));

    [HttpDelete("Delete/{linkCategoryId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid linkCategoryId)
        => Ok(await _mediator.Send(new DeleteLinkCategoryCommand { LinkCategoryId = linkCategoryId }));
}