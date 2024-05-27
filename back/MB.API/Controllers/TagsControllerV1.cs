using Azure;
using MB.Application.Features.Tags.Commands.CreateTag;
using MB.Application.Features.Tags.Commands.DeleteTag;
using MB.Application.Features.Tags.Commands.UpdateTag;
using MB.Application.Features.Tags.Queries.CountTags;
using MB.Application.Features.Tags.Queries.GetTagById;
using MB.Application.Features.Tags.Queries.GetTagsByCategory;
using MB.Application.Features.Tags.Queries.GetTagsByMood;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Application.Features.Tags.Queries.GetTagsList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Tags")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class TagsControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateTagCommandResponse>> Create([FromBody] CreateTagCommand createTagCommand)
        => Ok(await _mediator.Send(createTagCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountTagsQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountTagsQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetTagsListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetTagsListQuery()));

    [HttpGet("GetOneDetails/{tagId}")]
    public async Task<ActionResult<GetTagByIdQueryResponse>> GetOneDetails( Guid tagId)
        => Ok(await _mediator.Send(new GetTagByIdQuery { TagId = tagId }));

    [HttpGet("GetTagsList")]
    public async Task<ActionResult<GetTagsFullListQueryResponse>> GetFullList()
        => Ok(await _mediator.Send(new GetTagsFullListQuery()));

    [HttpGet("GetByCategory/{categoryId}")]
    public async Task<ActionResult<GetTagsByCategoryQueryResponse>> GetByCategory( Guid categoryId )
        => Ok(await _mediator.Send(new GetTagsByCategoryQuery { CategoryId = categoryId }));

    [HttpGet("GetByMood/{moodId}")]
    public async Task<ActionResult<GetTagsByMoodQueryResponse>> GetByMood( Guid moodId )
        => Ok(await _mediator.Send(new GetTagsByMoodQuery { MoodId = moodId }));

    [HttpGet("GetCheckBoxesByMood/{moodId}")]
    public async Task<ActionResult<GetTagsCheckBoxesByMoodQueryResponse>> GetCheckBoxesByMood(Guid moodId)
        => Ok(await _mediator.Send(new GetTagsCheckBoxesByMoodQuery { MoodId = moodId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateTagCommandResponse>> Update([FromBody] UpdateTagCommand updateTagCommand)
        => Ok(await _mediator.Send(updateTagCommand));

    [HttpDelete("Delete/{tagId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<DeleteTagCommandResponse>> Delete(Guid tagId)
        => Ok(await _mediator.Send(new DeleteTagCommand { Id = tagId }));
}