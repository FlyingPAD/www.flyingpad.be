using MB.Application;
using MB.Application.Features.Artists.Commands.CreateArtist;
using MB.Application.Features.Artists.Commands.DeleteArtist;
using MB.Application.Features.Artists.Commands.UpdateArtist;
using MB.Application.Features.Artists.Queries.CountArtists;
using MB.Application.Features.Artists.Queries.GetArtist;
using MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;
using MB.Application.Features.Artists.Queries.GetArtistDetails;
using MB.Application.Features.Artists.Queries.GetArtists;
using MB.Application.Features.Artists.Queries.GetArtistsByMood;
using MB.Application.Features.Artists.Queries.GetArtistsByStyle;
using MB.Application.Features.Artists.Queries.GetArtistsPage;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Artists")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class ArtistsControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Create")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ProducesResponseType(typeof(CreateArtistCommandResponse), 201)]
    [ProducesResponseType(typeof(BaseResponse), 400)]
    public async Task<ActionResult<CreateArtistCommandResponse>> Create([FromBody] CreateArtistCommand createArtistCommand, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(createArtistCommand, cancellationToken));

    [HttpGet("Count")]
    [ProducesResponseType(typeof(CountArtistsQueryResponse), 200)]
    public async Task<ActionResult<CountArtistsQueryResponse>> Count(CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new CountArtistsQuery(), cancellationToken));

    [HttpGet("GetAll")]
    [ProducesResponseType(typeof(GetArtistsQueryResponse), 200)]
    public async Task<ActionResult<GetArtistsQueryResponse>> GetAll(CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetArtistsQuery(), cancellationToken));

    [HttpGet("GetOne/{artistId}")]
    [ProducesResponseType(typeof(GetArtistQuery), 200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<GetArtistQuery>> GetOne(Guid artistId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetArtistQuery { ArtistId = artistId }, cancellationToken));

    [HttpGet("GetOneDetails/{artistId}")]
    [ProducesResponseType(typeof(GetArtistDetailsQuery), 200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<GetArtistDetailsQuery>> GetOneDetails(Guid artistId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetArtistDetailsQuery { ArtistId = artistId }, cancellationToken));

    [HttpGet("GetByMood/{businessId}")]
    [ProducesResponseType(typeof(GetArtistsByMoodQuery), 200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<GetArtistsByMoodQueryResponse>> GetByMood(Guid businessId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetArtistsByMoodQuery { BusinessId = businessId }, cancellationToken));

    [HttpGet("GetCheckBoxesByMood/{moodId}")]
    public async Task<ActionResult<GetArtistCheckBoxesByMoodQueryResponse>> GetCheckBoxesByMood(Guid moodId)
        => Ok(await _mediator.Send(new GetArtistCheckBoxesByMoodQuery { MoodId = moodId }));

    [HttpGet("GetByStyle/{businessId}")]
    [ProducesResponseType(typeof(GetArtistsByStyleQuery), 200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<GetArtistsByStyleQueryResponse>> GetByStyle(Guid businessId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetArtistsByStyleQuery { BusinessId = businessId }, cancellationToken));

    [HttpGet("GetPage")]
    [ProducesResponseType(typeof(GetArtistsPageQueryResponse), 200)]
    public async Task<ActionResult<GetArtistsPageQueryResponse>> GetPage(CancellationToken cancellationToken, Guid? styleId = null, Guid? startId = null, string abc = "", int pageSize = 10)
        => Ok(await _mediator.Send(new GetArtistsPageQuery { StyleId = styleId, StartId = startId, Abc = abc, PageSize = pageSize }, cancellationToken));

    [HttpPut("Update")]
    [Authorize]
    [ProducesResponseType(typeof(BaseResponse), 200)]
    [ProducesResponseType(typeof(BaseResponse), 400)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateArtistCommand updateArtistCommand, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(updateArtistCommand, cancellationToken));

    [HttpDelete("Delete/{businessId}")]
    [Authorize]
    [ProducesResponseType(typeof(BaseResponse), 200)]
    [ProducesResponseType(typeof(BaseResponse), 400)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<BaseResponse>> Delete(Guid businessId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new DeleteArtistCommand { BusinessId = businessId }, cancellationToken));
}