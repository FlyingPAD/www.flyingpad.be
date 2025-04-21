using MB.Application;
using MB.Application.Features.Artists.Commands.CreateArtist;
using MB.Application.Features.Artists.Commands.DeleteArtist;
using MB.Application.Features.Artists.Commands.UpdateArtist;
using MB.Application.Features.Artists.Queries.CountArtists;
using MB.Application.Features.Artists.Queries.GetAllArtists;
using MB.Application.Features.Artists.Queries.GetArtistById;
using MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;
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
    public async Task<ActionResult<CreateArtistCommandResponse>> Create([FromBody] CreateArtistCommand createArtistCommand, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(createArtistCommand, cancellationToken));

    [HttpGet("Count")]
    public async Task<ActionResult<CountArtistsQueryResponse>> Count(CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new CountArtistsQuery(), cancellationToken));

    [HttpGet("GetAll")]
    public async Task<ActionResult<GetAllArtistsQueryResponse>> GetAll(CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetAllArtistsQuery(), cancellationToken));

    [HttpGet("GetOneDetails/{artistId}")]
    public async Task<ActionResult<GetArtistByIdQuery>> GetById(Guid artistId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetArtistByIdQuery { ArtistId = artistId }, cancellationToken));

    [HttpGet("GetByMood/{moodId}")]
    public async Task<ActionResult<GetArtistsByMoodQueryResponse>> GetByMood(Guid moodId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetArtistsByMoodQuery { MoodId = moodId }, cancellationToken));

    [HttpGet("GetCheckBoxesByMood/{moodId}")]
    public async Task<ActionResult<GetArtistCheckBoxesByMoodQueryResponse>> GetCheckBoxesByMood(Guid moodId)
        => Ok(await _mediator.Send(new GetArtistCheckBoxesByMoodQuery { MoodId = moodId }));

    [HttpGet("GetByStyle/{styleId}")]
    public async Task<ActionResult<GetArtistsByStyleQueryResponse>> GetByStyle(Guid styleId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new GetArtistsByStyleQuery { StyleId = styleId }, cancellationToken));

    [HttpGet("GetPage")]
    public async Task<ActionResult<GetArtistsPageQueryResponse>> GetPage(CancellationToken cancellationToken, Guid? styleId = null, Guid? startId = null, string abc = "", int pageSize = 10)
        => Ok(await _mediator.Send(new GetArtistsPageQuery { StyleId = styleId, StartId = startId, Abc = abc, PageSize = pageSize }, cancellationToken));

    [HttpPut("Update")]
    [Authorize]
    public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateArtistCommand updateArtistCommand, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(updateArtistCommand, cancellationToken));

    [HttpDelete("Delete/{artistId}")]
    [Authorize]
    public async Task<ActionResult<BaseResponse>> Delete(Guid artistId, CancellationToken cancellationToken)
        => Ok(await _mediator.Send(new DeleteArtistCommand { ArtistId = artistId }, cancellationToken));
}