using MB.Application;
using MB.Application.Features.Franchises.Commands.CreateFranchise;
using MB.Application.Features.Franchises.Commands.DeleteFranchise;
using MB.Application.Features.Franchises.Commands.UpdateFranchise;
using MB.Application.Features.Franchises.Queries.CountFranchises;
using MB.Application.Features.Franchises.Queries.GetFranchiseById;
using MB.Application.Features.Franchises.Queries.GetFranchisesByMedium;
using MB.Application.Features.Franchises.Queries.GetFranchisesByModel;
using MB.Application.Features.Franchises.Queries.GetFranchisesByMood;
using MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel;
using MB.Application.Features.Franchises.Queries.GetFranchisesList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Franchises")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class FranchisesControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateFranchiseCommandResponse>> Create([FromBody] CreateFranchiseCommand createFranchiseCommand)
        => Ok(await _mediator.Send(createFranchiseCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountFranchisesQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountFranchisesQuery()));
    
    [HttpGet("GetAll")]
    public async Task<ActionResult<GetAllFranchisesQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetAllFranchisesQuery()));

    [HttpGet("GetOneDetails/{businessId}")]
    public async Task<ActionResult<GetFranchiseByIdQueryResponse>> GetById(Guid businessId)
        => Ok(await _mediator.Send(new GetFranchiseByIdQuery { FranchiseId = businessId }));

    [HttpGet("GetByMood/{moodId}")]
    public async Task<ActionResult<GetFranchisesByMoodQueryResponse>> GetByMood(Guid moodId)
        => Ok(await _mediator.Send(new GetFranchisesByMoodQuery { MoodId = moodId }));

    [HttpGet("GetByModel/{modelId}")]
    public async Task<ActionResult<GetFranchisesByModelQueryResponse>> GetByModel(Guid modelId)
        => Ok(await _mediator.Send(new GetFranchisesByModelQuery { ModelId = modelId }));

    [HttpGet("GetByMedium/{mediumId}")]
    public async Task<ActionResult<GetFranchisesByMediumQueryResponse>> GetByMedium(Guid mediumId)
        => Ok(await _mediator.Send(new GetFranchisesByMediumQuery { MediumId = mediumId }));

    [HttpGet("GetCheckBoxesByModel/{modelId}")]
    public async Task<ActionResult<GetFranchisesCheckBoxesByModelQueryResponse>> GetCheckBoxesByModel(Guid modelId)
        => Ok(await _mediator.Send(new GetFranchisesCheckBoxesByModelQuery { ModelId = modelId }));

    [HttpGet("GetFranchisesList")]
    public async Task<ActionResult<GetFranchisesListQueryResponse>> GetFranchisesList()
        => Ok(await _mediator.Send(new GetFranchisesListQuery()));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateFranchiseCommand updateFranchiseCommand)
        => Ok(await _mediator.Send(updateFranchiseCommand));

    [HttpDelete("Delete/{franchiseId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid franchiseId)
        => Ok(await _mediator.Send(new DeleteFranchiseCommand { FranchiseId = franchiseId }));
}