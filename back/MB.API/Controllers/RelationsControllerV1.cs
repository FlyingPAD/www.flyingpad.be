using MB.Application.Features.Relations.Commands.CreateRelationsMoodArtist;
using MB.Application.Features.Relations.Commands.CreateRelationsMoodModel;
using MB.Application.Features.Relations.Commands.CreateRelationsMoodTags;
using MB.Application.Features.Relations.Commands.RAS;
using MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByArtist;
using MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByStyle;
using MB.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Relations")]
[ApiController]
[ApiExplorerSettings(GroupName = "relations")]
public class RelationsControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    // =================================================================================================================
    // (C) Create
    // =================================================================================================================

    /// <summary>
    /// Create RAS
    /// </summary>
    [HttpPost("ArtistStyle/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRelationsArtistStyle([FromBody] CreateRelationsArtistStyleCommand rasCommand)
    {
        var response = await _mediator.Send(rasCommand);
        return Ok(response);
    }

    /// <summary>
    /// Create RMT
    /// </summary>
    [HttpPost("MoodTag/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRelationsMoodTag([FromBody] CreateRelationsMoodTagsCommand rmtCommand)
        => Ok(await _mediator.Send(rmtCommand));

    /// <summary>
    /// Create RMA
    /// </summary>
    [HttpPost("MoodArtist/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRelationsMoodArtist([FromBody] CreateRelationsMoodArtistCommand rmaCommand)
        => Ok(await _mediator.Send(rmaCommand));

    /// <summary>
    /// Create RMM
    /// </summary>
    [HttpPost("MoodModel/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRelationsMoodModel([FromBody] CreateRelationsMoodModelCommand rmmCommand)
        =>Ok(await _mediator.Send(rmmCommand));

    // =================================================================================================================
    // (R) Retrieve
    // =================================================================================================================

    /// <summary>
    /// Check if Relations
    /// </summary>
    [HttpGet("ArtistStyle/CheckRelationsByArtist")]
    public async Task<ActionResult<CheckRelationsArtistStyleByArtistQueryResponse>> CheckRelationsArtistStyleByArtist( Guid artistId )
    {
        var response = await _mediator.Send(new CheckRelationsArtistStyleByArtistQuery { ArtistId = artistId });
        return Ok(response);
    }

    /// <summary>
    /// Check if Relations
    /// </summary>
    [HttpGet("ArtistStyle/CheckRelationsByStyle")]
    public async Task<ActionResult<CheckRelationsArtistStyleByStyleQueryResponse>> CheckRelationsArtistStyleByStyle( Guid styleId )
    {
        var response = await _mediator.Send(new CheckRelationsArtistStyleByStyleQuery { StyleId = styleId });
        return Ok(response);
    }
}