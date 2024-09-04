using MB.Application.Features.Models.Commands.CreateModel;
using MB.Application.Features.Models.Commands.DeleteModel;
using MB.Application.Features.Models.Commands.UpdateModel;
using MB.Application.Features.Models.Queries.CountModels;
using MB.Application.Features.Models.Queries.GetModelById;
using MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;
using MB.Application.Features.Models.Queries.GetModelsByFranchise;
using MB.Application.Features.Models.Queries.GetModelsByMood;
using MB.Application.Features.Models.Queries.GetModelsList;
using MB.Application.Models;
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

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateModelCommandResponse>> Create([FromBody] CreateModelCommand createModelCommand)
        => Ok(await _mediator.Send(createModelCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountModelsQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountModelsQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetModelsListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetModelsListQuery()));

    [HttpGet("GetOneDetails/{modelId}")]
    public async Task<IActionResult> GetOneDetails(Guid modelId)
        => Ok(await _mediator.Send(new GetModelByIdQuery { ModelId = modelId }));

    [HttpGet("GetByMood/{moodId}")]
    public async Task<ActionResult<GetModelsByMoodQueryResponse>> GetByMood(Guid moodId)
        => Ok(await _mediator.Send(new GetModelsByMoodQuery { MoodId = moodId }));

    [HttpGet("GetByFranchise/{franchiseId}")]
    public async Task<ActionResult<GetModelsByFranchiseQueryResponse>> GetByFranchise(Guid franchiseId)
        => Ok(await _mediator.Send(new GetModelsByFranchiseQuery { FranchiseId = franchiseId }));

    [HttpGet("GetCheckBoxesByMood/{moodId}")]
    public async Task<ActionResult<GetModelCheckBoxesByMoodQueryResponse>> GetCheckBoxesByMood(Guid moodId)
        => Ok(await _mediator.Send(new GetModelCheckBoxesByMoodQuery { MoodId = moodId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<IActionResult> Update([FromBody] UpdateModelCommand updateModelCommand)
        => Ok(await _mediator.Send(updateModelCommand));

    [HttpDelete("Delete/{modelId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid modelId)
        => Ok(await _mediator.Send(new DeleteModelCommand { ModelId = modelId }));
}