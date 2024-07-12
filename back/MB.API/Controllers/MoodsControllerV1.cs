using MB.Application.Features.Moods.Commands.CreateMood;
using MB.Application.Features.Moods.Commands.CreateMoodImage;
using MB.Application.Features.Moods.Commands.DeleteMood;
using MB.Application.Features.Moods.Commands.UpdateMood;
using MB.Application.Features.Moods.Commands.UpdateMoodScore;
using MB.Application.Features.Moods.Queries;
using MB.Application.Features.Moods.Queries.CountMoods;
using MB.Application.Features.Moods.Queries.GetMoodById;
using MB.Application.Features.Moods.Queries.GetMoodsByArtist;
using MB.Application.Features.Moods.Queries.GetMoodsByFranchise;
using MB.Application.Features.Moods.Queries.GetMoodsByModel;
using MB.Application.Features.Moods.Queries.GetMoodsByTag;
using MB.Application.Features.Moods.Queries.GetMoodsList;
using MB.Application.Features.Moods.Queries.GetRandomMoodQuery;
using MB.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Moods")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class MoodsControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMoodCommandResponse>> Create([FromBody] CreateMoodCommand createMoodCommand)
        => Ok(await _mediator.Send(createMoodCommand));

    [HttpPost("CreateMoodImage")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMoodImageCommandResponse>> CreateMoodImage([FromBody] CreateMoodImageCommand createMoodImageCommand)
        => Ok(await _mediator.Send(createMoodImageCommand));

    [HttpGet("Count")]
    public async Task<ActionResult<CountMoodsQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountMoodsQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetMoodsListQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetMoodsListQuery()));

    [HttpGet("GetOneDetailsRandom")]
    public async Task<ActionResult<GetRandomMoodQueryResponse>> GetOneDetailsRandom()
        => Ok(await _mediator.Send(new GetRandomMoodQuery()));

    [HttpGet("GetOneDetails/{moodId}")]
    public async Task<ActionResult<GetMoodByIdQueryResponse>> GetOneDetails(Guid moodId)
        => Ok(await _mediator.Send(new GetMoodByIdQuery { Id = moodId }));

    [HttpGet("GetByTag/{tagId}")]
    public async Task<ActionResult<GetMoodsByTagQueryResponse>> GetByTag(Guid tagId)
        => Ok(await _mediator.Send(new GetMoodsByTagQuery { TagId = tagId }));

    [HttpGet("GetByArtist/{artistId}")]
    public async Task<ActionResult<GetMoodsByArtistQueryResponse>> GetByArtist(Guid artistId)
        => Ok(await _mediator.Send(new GetMoodsByArtistQuery { ArtistId = artistId }));

    [HttpGet("GetByModel/{modelId}")]
    public async Task<ActionResult<GetMoodsByModelQueryResponse>> GetByModel(Guid modelId)
        => Ok(await _mediator.Send(new GetMoodsByModelQuery { ModelId = modelId }));

    [HttpGet("GetByFranchise/{franchiseId}")]
    public async Task<ActionResult<GetMoodsByFranchiseQueryResponse>> GetByFranchise(Guid franchiseId)
        => Ok(await _mediator.Send(new GetMoodsByFranchiseQuery { FranchiseId = franchiseId }));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateMoodCommandResponse>> Update([FromBody] UpdateMoodCommand updateMoodCommand)
        => Ok(await _mediator.Send(updateMoodCommand));

    [HttpPut("UpdateScore")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateMoodScoreCommandResponse>> UpdateScore([FromBody] UpdateMoodScoreCommand command )
        => Ok(await _mediator.Send(command));

    [HttpDelete("Delete/{moodId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete( Guid moodId )
        => Ok(await _mediator.Send(new DeleteMoodCommand { MoodId = moodId }));
}