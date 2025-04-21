using MB.Application;
using MB.Application.Features.Relations.Commands.CreateRelationsModelFranchise;
using MB.Application.Features.Relations.Commands.CreateRelationsMoodArtist;
using MB.Application.Features.Relations.Commands.CreateRelationsMoodModel;
using MB.Application.Features.Relations.Commands.CreateRelationsMoodTags;
using MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByArtist;
using MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByStyle;
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

    [HttpPost("ModelFranchise/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRMF([FromBody] CreateRelationsModelFranchiseCommand rmfCommand)
        => Ok(await _mediator.Send(rmfCommand));

    [HttpPost("MoodTag/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRMT([FromBody] CreateRelationsMoodTagsCommand rmtCommand)
        => Ok(await _mediator.Send(rmtCommand));

    [HttpPost("MoodArtist/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRMA([FromBody] CreateRelationsMoodArtistCommand rmaCommand)
        => Ok(await _mediator.Send(rmaCommand));

    [HttpPost("MoodModel/Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<BaseResponse>> InsertRMM([FromBody] CreateRelationsMoodModelCommand rmmCommand)
        => Ok(await _mediator.Send(rmmCommand));

    [HttpGet("ArtistStyle/CheckRelationsByArtist")]
    public async Task<ActionResult<CheckRelationsArtistStyleByArtistQueryResponse>> CountRASByArtist( Guid artistId )
        => Ok(await _mediator.Send(new CheckRelationsArtistStyleByArtistQuery { ArtistId = artistId }));

    [HttpGet("ArtistStyle/CheckRelationsByStyle")]
    public async Task<ActionResult<CheckRelationsArtistStyleByStyleQueryResponse>> CountRASByStyle( Guid styleId )
        => Ok(await _mediator.Send(new CheckRelationsArtistStyleByStyleQuery { StyleId = styleId }));
}