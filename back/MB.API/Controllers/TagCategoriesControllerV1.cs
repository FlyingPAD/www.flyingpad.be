using MB.Application.Features.TagCategories.Commands.CreateTagCategory;
using MB.Application.Features.TagCategories.Commands.DeleteTagCategory;
using MB.Application.Features.TagCategories.Commands.UpdateTagCategory;
using MB.Application.Features.TagCategories.Queries.CountTagCategories;
using MB.Application.Features.TagCategories.Queries.GetTagCategoryById;
using MB.Application.Features.TagCategories.Queries.GetTagCategoriesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MB.Application.Models;

namespace MB.API.Controllers;

[Route("api/V1/TagCategories")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class TagCategoriesControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateTagCategoryCommandResponse>> Create([FromBody] CreateTagCategoryCommand createTagCategoryCommand)
        => Ok(await _mediator.Send(createTagCategoryCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountTagCategoriesQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountTagCategoriesQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetTagCategoriesListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetTagCategoriesListQuery()));

    [HttpGet("GetOneDetails/{categoryId}")]
    public async Task<ActionResult<GetTagCategoryByIdQuery>> GetById(Guid categoryId)
        => Ok(await _mediator.Send(new GetTagCategoryByIdQuery { Id = categoryId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateTagCategoryCommand updateTagCategoryCommand)
        => Ok(await _mediator.Send(updateTagCategoryCommand));

    [HttpDelete("Delete/{tagCategoryId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid tagCategoryId)
        => Ok(await _mediator.Send(new DeleteTagCategoryCommand { TagCategoryId = tagCategoryId }));
}