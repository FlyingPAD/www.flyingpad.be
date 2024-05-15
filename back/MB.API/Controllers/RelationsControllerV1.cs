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

    /// <summary>
    /// Create RAS
    /// </summary>
    [HttpPost("ArtistStyle/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRAS([FromBody] CreateRelationsArtistStyleCommand rasCommand)
        => Ok(await _mediator.Send(rasCommand));

    /// <summary>
    /// Create RMT
    /// </summary>
    [HttpPost("MoodTag/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRMT([FromBody] CreateRelationsMoodTagsCommand rmtCommand)
        => Ok(await _mediator.Send(rmtCommand));

    /// <summary>
    /// Create RMA
    /// </summary>
    [HttpPost("MoodArtist/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRMA([FromBody] CreateRelationsMoodArtistCommand rmaCommand)
        => Ok(await _mediator.Send(rmaCommand));

    /// <summary>
    /// Create RMM
    /// </summary>
    [HttpPost("MoodModel/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRMM([FromBody] CreateRelationsMoodModelCommand rmmCommand)
        => Ok(await _mediator.Send(rmmCommand));

    /// <summary>
    /// Check if Relations
    /// </summary>
    [HttpGet("ArtistStyle/CheckRelationsByArtist")]
    public async Task<ActionResult<CheckRelationsArtistStyleByArtistQueryResponse>> CheckRelationsArtistStyleByArtist( Guid artistId )
        => Ok(await _mediator.Send(new CheckRelationsArtistStyleByArtistQuery { ArtistId = artistId }));

    /// <summary>
    /// Check if Relations
    /// </summary>
    [HttpGet("ArtistStyle/CheckRelationsByStyle")]
    public async Task<ActionResult<CheckRelationsArtistStyleByStyleQueryResponse>> CheckRelationsArtistStyleByStyle( Guid styleId )
        => Ok(await _mediator.Send(new CheckRelationsArtistStyleByStyleQuery { StyleId = styleId }));
}