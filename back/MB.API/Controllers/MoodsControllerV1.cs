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

    /// <summary>
    /// Create
    /// </summary>
    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMoodCommandResponse>> Create([FromBody] CreateMoodCommand createMoodCommand)
    {
        var response = await _mediator.Send( createMoodCommand );
        return Ok(response);
    }

    /// <summary>
    /// Creates a new mood ( Image )
    /// </summary>
    [HttpPost("CreateMoodImage")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMoodImageCommandResponse>> CreateMoodImage([FromBody] CreateMoodImageCommand createMoodImageCommand)
    {
        var response = await _mediator.Send(createMoodImageCommand);
        return Ok(response);
    }

    /// <summary>
    /// Count
    /// </summary>
    [HttpGet("Count")]
    public async Task<ActionResult<CountMoodsQueryResponse>> Count()
    {
        var response = await _mediator.Send( new CountMoodsQuery() );
        return Ok(response);
    }

    /// <summary>
    /// Get All
    /// </summary>
    [HttpGet("GetAll")]
    public async Task<ActionResult<GetMoodsListQueryResponse>> GetAll()
    {
        var response = await _mediator.Send( new GetMoodsListQuery() );
        return Ok(response);
    }

    /// <summary>
    /// Get One Details : Random
    /// </summary>
    /// <returns>Query Response</returns>
    [HttpGet("GetOneDetailsRandom")]
    public async Task<ActionResult<GetRandomMoodQueryResponse>> GetOneDetailsRandom()
    {
        var response = await _mediator.Send( new GetRandomMoodQuery() );
        return Ok(response);
    }

    /// <summary>
    /// Get One Details
    /// </summary>
    [HttpGet("GetOneDetails/{moodId}")]
    public async Task<ActionResult<GetMoodByIdQueryResponse>> GetOneDetails(Guid moodId)
    {
        var response = await _mediator.Send(new GetMoodByIdQuery { Id = moodId });
        return Ok(response);
    }

    /// <summary>
    /// Get By Tag
    /// </summary>
    [HttpGet("GetByTag/{tagId}")]
    public async Task<ActionResult<GetMoodsByTagQueryResponse>> GetByTag(Guid tagId)
    {
        var response = await _mediator.Send(new GetMoodsByTagQuery { TagId = tagId });
        return Ok(response);
    }

    /// <summary>
    /// Get By Artist
    /// </summary>
    [HttpGet("GetByArtist/{artistId}")]
    public async Task<ActionResult<GetMoodsByArtistQueryResponse>> GetByArtist(Guid artistId)
    {
        var response = await _mediator.Send(new GetMoodsByArtistQuery { ArtistId = artistId });
        return Ok(response);
    }

    /// <summary>
    /// Get By Model
    /// </summary>
    [HttpGet("GetByModel/{modelId}")]
    public async Task<ActionResult<GetMoodsByModelQueryResponse>> GetByModel(Guid modelId)
    {
        var response = await _mediator.Send(new GetMoodsByModelQuery { ModelId = modelId });
        return Ok(response);
    }

    /// <summary>
    /// Get By Franchise
    /// </summary>
    [HttpGet("GetByFranchise/{franchiseId}")]
    public async Task<ActionResult<GetMoodsByFranchiseQueryResponse>> GetByFranchise(Guid franchiseId)
    {
        var response = await _mediator.Send(new GetMoodsByFranchiseQuery { FranchiseId = franchiseId });
        return Ok(response);
    }

    /// <summary>
    /// Update
    /// </summary>
    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateMoodCommandResponse>> Update([FromBody] UpdateMoodCommand updateMoodCommand)
    {
        var response = await _mediator.Send(updateMoodCommand);
        return Ok(response);
    }

    [HttpPut("UpdateScore")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<UpdateMoodScoreCommandResponse>> UpdateScore([FromBody] UpdateMoodScoreCommand command )
    {
        var response = await _mediator.Send( command );
        return Ok(response);
    }

    /// <summary>
    /// Delete
    /// </summary>
    [HttpDelete("Delete/{moodId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete( Guid moodId )
    {
        var response = await _mediator.Send(new DeleteMoodCommand { MoodId = moodId });
        return Ok(response);
    }
}