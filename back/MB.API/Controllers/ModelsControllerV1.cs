using MB.Application.Features.Models.Commands.CreateModel;
using MB.Application.Features.Models.Commands.DeleteModel;
using MB.Application.Features.Models.Commands.UpdateModel;
using MB.Application.Features.Models.Queries.CountModels;
using MB.Application.Features.Models.Queries.GetModelById;
using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Application.Features.Models.Queries.GetModelsByFranchise;
using MB.Application.Features.Models.Queries.GetModelsByMood;
using MB.Application.Features.Models.Queries.GetModelsList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Models")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class ModelsControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    /// <summary>
    /// Create
    /// </summary>
    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateModelCommandResponse>> Create([FromBody] CreateModelCommand createModelCommand)
    => Ok(await _mediator.Send(createModelCommand));

    /// <summary>
    /// Count
    /// </summary>
    [HttpGet("Count")]
    public async Task<ActionResult<CountModelsQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountModelsQuery()));

    /// <summary>
    /// Get All
    /// </summary>
    [HttpGet("GetAll")]
    public async Task<ActionResult<GetModelsListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetModelsListQuery()));

    /// <summary>
    /// Get One Details
    /// </summary>
    [HttpGet("GetOneDetails/{modelId}")]
    public async Task<ActionResult<GetModelByIdQueryResponse>> GetOneDetails(Guid modelId)
        => Ok(await _mediator.Send(new GetModelByIdQuery { ModelId = modelId }));

    /// <summary>
    /// Get by Mood
    /// </summary>
    [HttpGet("GetByMood/{moodId}")]
    [ProducesResponseType(typeof(GetModelsByMoodQuery), 200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<GetModelsByMoodQueryResponse>> GetByMood(Guid moodId)
    {
        var response = await _mediator.Send(new GetModelsByMoodQuery { MoodId = moodId });

        if (response == null)
        {
            return NotFound();
        }
        return Ok(response);
    }

    /// <summary>
    /// Get by Franchise
    /// </summary>
    [HttpGet("GetByFranchise/{franchiseId}")]
    [ProducesResponseType(typeof(GetModelsByFranchiseQuery), 200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<GetModelsByFranchiseQueryResponse>> GetByFranchise(Guid franchiseId)
    {
        var response = await _mediator.Send(new GetModelsByFranchiseQuery { FranchiseId = franchiseId });

        if (response == null)
        {
            return NotFound();
        }
        return Ok(response);
    }

    /// <summary>
    /// Get By Mood ( Checkboxes )
    /// </summary>
    [HttpGet("GetCheckBoxesByMood/{moodId}")]
    public async Task<ActionResult<GetModelCheckBoxesByMoodQueryResponse>> GetCheckBoxesByMood(Guid moodId)
        => Ok(await _mediator.Send(new GetModelCheckBoxesByMoodQuery { MoodId = moodId }));

    /// <summary>
    /// Update
    /// </summary>
    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateModelCommandResponse>> Update(Guid modelId, [FromBody] UpdateModelCommand updateModelCommand)
    {
        if (modelId != updateModelCommand.Id)
        {
            return BadRequest("ID in the URL does not match ID in the request body.");
        }

        var response = await _mediator.Send(updateModelCommand);
        return Ok(response);
    }

    /// <summary>
    /// Delete
    /// </summary>
    [HttpDelete("Delete/{modelId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<DeleteModelCommandResponse>> Delete(Guid modelId)
        => Ok(await _mediator.Send(new DeleteModelCommand { ModelId = modelId }));
}