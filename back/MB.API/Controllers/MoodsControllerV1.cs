using MB.Application.Features.Moods.Commands.CreateMood;
using MB.Application.Features.Moods.Commands.CreateMoodImage;
using MB.Application.Features.Moods.Commands.CreateMoodVideo;
using MB.Application.Features.Moods.Commands.CreateMoodYouTube;
using MB.Application.Features.Moods.Commands.CreateSoundCloudAudio;
using MB.Application.Features.Moods.Commands.DeleteMood;
using MB.Application.Features.Moods.Commands.MultiTags;
using MB.Application.Features.Moods.Commands.UpdateMood;
using MB.Application.Features.Moods.Commands.UpdateMoodScore;
using MB.Application.Features.Moods.Queries;
using MB.Application.Features.Moods.Queries.CountMoods;
using MB.Application.Features.Moods.Queries.GetAllMoods;
using MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;
using MB.Application.Features.Moods.Queries.GetMoodById;
using MB.Application.Features.Moods.Queries.GetMoodsByArtist;
using MB.Application.Features.Moods.Queries.GetMoodsByFranchise;
using MB.Application.Features.Moods.Queries.GetMoodsByModel;
using MB.Application.Features.Moods.Queries.GetMoodsByTag;
using MB.Application.Features.Moods.Queries.GetMoodsByTagCategory;
using MB.Application.Features.Moods.Queries.GetRandomMood;
using MB.Application.Models;
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
    public async Task<ActionResult<CreateMoodCommandResponse>> Create([FromBody] CreateMoodCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPost("CreateMoodImage")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMoodImageCommandResponse>> CreateImage([FromBody] CreateMoodImageCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPost("CreateMoodVideo")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMoodVideoCommandResponse>> CreateVideo([FromBody] CreateMoodVideoCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPost("CreateMoodVideoYouTube")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateMoodYouTubeCommandResponse>> CreateVideoYouTube([FromBody] CreateMoodYouTubeCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPost("CreateMoodAudioSoundCloud")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<CreateSoundCloudAudioCommandResponse>> CreateAudioSoundCloud([FromBody] CreateSoundCloudAudioCommand command)
        => Ok(await _mediator.Send(command));

    [HttpGet("Count")]
    public async Task<ActionResult<CountMoodsQueryResponse>> Count()
        => Ok(await _mediator.Send(new CountMoodsQuery()));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetAllMoodsQueryResponse>> GetAll()
        => Ok(await _mediator.Send(new GetAllMoodsQuery()));

    [HttpGet("GetOneDetailsRandom")]
    public async Task<ActionResult<GetRandomMoodQueryResponse>> GetOneDetailsRandom()
        => Ok(await _mediator.Send(new GetRandomMoodQuery()));

    [HttpGet("GetOneDetails/{moodId}")]
    public async Task<ActionResult<GetMoodByIdQueryResponse>> GetOneDetails(Guid moodId)
        => Ok(await _mediator.Send(new GetMoodByIdQuery { MoodId = moodId }));

    [HttpGet("GetByTag/{tagId}")]
    public async Task<ActionResult<GetMoodsByTagQueryResponse>> GetByTag(Guid tagId)
        => Ok(await _mediator.Send(new GetMoodsByTagQuery { TagId = tagId }));

    [HttpGet("GetByTagCategory/{tagCategoryId}")]
    public async Task<ActionResult<GetMoodsByTagCategoryQueryResponse>> GetByTagCategory(Guid tagCategoryId)
        => Ok(await _mediator.Send(new GetMoodsByTagCategoryQuery { TagCategoryId = tagCategoryId }));

    [HttpGet("GetByArtist/{artistId}")]
    public async Task<ActionResult<GetMoodsByArtistQueryResponse>> GetByArtist(Guid artistId)
        => Ok(await _mediator.Send(new GetMoodsByArtistQuery { ArtistId = artistId }));

    [HttpGet("GetByModel/{modelId}")]
    public async Task<ActionResult<GetMoodsByModelQueryResponse>> GetByModel(Guid modelId)
        => Ok(await _mediator.Send(new GetMoodsByModelQuery { ModelId = modelId }));

    [HttpGet("GetByFranchise/{franchiseId}")]
    public async Task<ActionResult<GetMoodsByFranchiseQueryResponse>> GetByFranchise(Guid franchiseId)
        => Ok(await _mediator.Send(new GetMoodsByFranchiseQuery { FranchiseId = franchiseId }));

    [HttpPost("GetCommonTagsByMoods")]
    public async Task<ActionResult<GetCommonTagsByMoodsQueryResponse>> GetCommonTagsByMoods([FromBody] GetCommonTagsByMoodsQuery getCommonTagsByMoods)
        => Ok(await _mediator.Send(getCommonTagsByMoods));

    [HttpPut("Update")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateMoodCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPost("MultiTags")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> MultiTags([FromBody] MultiTagsCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPut("UpdateScore")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> UpdateScore([FromBody] UpdateMoodScoreCommand command)
        => Ok(await _mediator.Send(command));

    [HttpDelete("Delete/{moodId}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> Delete(Guid moodId)
        => Ok(await _mediator.Send(new DeleteMoodCommand { MoodId = moodId }));
}