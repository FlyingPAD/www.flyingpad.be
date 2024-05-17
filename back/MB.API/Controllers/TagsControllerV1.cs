using MB.Application.Features.Tags.Commands.CreateTag;
using MB.Application.Features.Tags.Commands.DeleteTag;
using MB.Application.Features.Tags.Commands.UpdateTag;
using MB.Application.Features.Tags.Queries.CountTags;
using MB.Application.Features.Tags.Queries.GetTagById;
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

    /// <summary>
    /// Create
    /// </summary>
    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateTagCommandResponse>> CreateTag([FromBody] CreateTagCommand createTagCommand)
    {
        var response = await _mediator.Send(createTagCommand);
        return Ok(response);
    }

    /// <summary>
    /// Count
    /// </summary>
    [HttpGet("Count")]
    public async Task<ActionResult<CountTagsQueryResponse>> Count()
    {
        var response = await _mediator.Send( new CountTagsQuery() );
        return Ok(response);
    }

    /// <summary>
    /// Get All
    /// </summary>
    [HttpGet("GetAll")]
    public async Task<ActionResult<GetTagsListQueryResponse>> GetAll()
    {
        var response = await _mediator.Send( new GetTagsListQuery() );
        return Ok(response);
    }

    /// <summary>
    /// Get One Details
    /// </summary>
    [HttpGet("GetOneDetails/{tagId}")]
    public async Task<ActionResult<GetTagByIdQueryResponse>> GetOneDetails( Guid tagId)
    {
        var response = await _mediator.Send( new GetTagByIdQuery { TagId = tagId } );
        return Ok(response);
    }

    /// <summary>
    /// Get Tags With Categories ( Full List )
    /// </summary>
    [HttpGet("GetTagsList")]
    public async Task<ActionResult<GetTagsFullListQueryResponse>> GetTagsFullList()
    {
        var response = await _mediator.Send( new GetTagsFullListQuery() );
        return Ok(response);
    }

    /// <summary>
    /// Get By Mood
    /// </summary>
    [HttpGet("GetByMood/{moodId}")]
    public async Task<ActionResult<GetTagsByMoodQueryResponse>> GetByMood( Guid moodId )
    {
        var response = await _mediator.Send( new GetTagsByMoodQuery { MoodId = moodId } );
        return Ok(response);
    }

    /// <summary>
    /// Get By Mood ( Checkboxes )
    /// </summary>
    [HttpGet("GetCheckBoxesByMood/{moodId}")]
    public async Task<ActionResult<GetTagsCheckBoxesByMoodQueryResponse>> GetCheckBoxesByMood(Guid moodId)
    {
        var response = await _mediator.Send(new GetTagsCheckBoxesByMoodQuery { MoodId = moodId });
        return Ok(response);
    }

    /// <summary>
    /// Update
    /// </summary>
    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateTagCommandResponse>> Update(Guid tagId, [FromBody] UpdateTagCommand updateTagCommand)
    {
        if (tagId != updateTagCommand.Id)
        {
            return BadRequest("ID in the URL does not match ID in the request body.");
        }

        var response = await _mediator.Send(updateTagCommand);
        return Ok(response);
    }

    /// <summary>
    /// Delete
    /// </summary>
    [HttpDelete("Delete/{tagId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<DeleteTagCommandResponse>> Delete(Guid tagId)
    {
        var response = await _mediator.Send(new DeleteTagCommand { Id = tagId });
        return Ok(response);
    }
}