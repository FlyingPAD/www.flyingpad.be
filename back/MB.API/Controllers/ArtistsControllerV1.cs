using MB.Application.Features.Artists.Commands.CreateArtist;
using MB.Application.Features.Artists.Commands.DeleteArtist;
using MB.Application.Features.Artists.Commands.UpdateArtist;
using MB.Application.Features.Artists.Queries.CountArtists;
using MB.Application.Features.Artists.Queries.GetArtist;
using MB.Application.Features.Artists.Queries.GetArtistDetails;
using MB.Application.Features.Artists.Queries.GetArtists;
using MB.Application.Features.Artists.Queries.GetArtistsByMood;
using MB.Application.Features.Artists.Queries.GetArtistsByStyle;
using MB.Application.Features.Artists.Queries.GetArtistsPage;
using MB.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers
{
    [Route("api/V1/Artists")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "features")]
    public class ArtistsControllerV1(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // =================================================================================================================
        // (C) Create
        // =================================================================================================================

        /// <summary>
        /// Create
        /// </summary>
        [HttpPost("Create")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [ProducesResponseType(typeof(CreateArtistCommandResponse), 201)]
        [ProducesResponseType(typeof(BaseResponse), 400)]
        public async Task<ActionResult<CreateArtistCommandResponse>> Create([FromBody] CreateArtistCommand createArtistCommand)
        {
            var response = await _mediator.Send(createArtistCommand);
            return Ok(response);
        }

        // =================================================================================================================
        // (R) Retrieve
        // =================================================================================================================

        /// <summary>
        /// Count
        /// </summary>
        [HttpGet("Count")]
        [ProducesResponseType(typeof(CountArtistsQueryResponse), 200)]
        public async Task<ActionResult<CountArtistsQueryResponse>> Count()
        {
            var response = await _mediator.Send(new CountArtistsQuery());

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(new BaseResponse
                {
                    Success = false,
                    Message = "Une erreur est survenue lors du comptage des artistes."
                });
            }
        }

        /// <summary>
        /// Get All
        /// </summary>
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(GetArtistsQueryResponse), 200)]
        public async Task<ActionResult<GetArtistsQueryResponse>> GetAll()
        {
            var response = await _mediator.Send( new GetArtistsQuery() );
            return Ok(response);
        }

        /// <summary>
        /// Get One
        /// </summary>
        [HttpGet("GetOne/{artistId}")]
        [ProducesResponseType(typeof(GetArtistQuery), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<GetArtistQuery>> GetOne(Guid artistId)
        {
            var response = await _mediator.Send(new GetArtistQuery { ArtistId = artistId });

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        /// <summary>
        /// Get One Details
        /// </summary>
        [HttpGet("GetOneDetails/{artistId}")]
        [ProducesResponseType(typeof(GetArtistDetailsQuery), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<GetArtistDetailsQuery>> GetOneDetails(Guid artistId)
        {
            var response = await _mediator.Send(new GetArtistDetailsQuery { ArtistId = artistId });

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        /// <summary>
        /// Get by Mood
        /// </summary>
        [HttpGet("GetByMood/{businessId}")]
        [ProducesResponseType(typeof(GetArtistsByMoodQuery), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<GetArtistsByMoodQueryResponse>> GetByMood(Guid businessId)
        {
            var response = await _mediator.Send(new GetArtistsByMoodQuery { BusinessId = businessId });

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        /// <summary>
        /// Get by Style
        /// </summary>
        [HttpGet("GetByStyle/{businessId}")]
        [ProducesResponseType(typeof(GetArtistsByStyleQuery), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<GetArtistsByStyleQueryResponse>> GetByStyle(Guid businessId)
        {
            var response = await _mediator.Send( new GetArtistsByStyleQuery { BusinessId = businessId } );

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        /// <summary>
        /// Get Page
        /// </summary>
        /// <param name="styleId">The ID of the style to filter by (optional).</param>
        /// <param name="startId">The starting ID for pagination (optional).</param>
        /// <param name="abc">A string to filter artists containing specific characters (optional).</param>
        /// <param name="pageSize">The number of artists to include on each page (default is 10).</param>
        /// <returns>Query Response with a paginated list of artists.</returns>
        [HttpGet("GetPage")]
        [ProducesResponseType(typeof(GetArtistsPageQueryResponse), 200)]
        public async Task<ActionResult<GetArtistsPageQueryResponse>> GetPage(Guid? styleId = null, Guid? startId = null, string abc = "", int pageSize = 10)
        {
            var response = await _mediator.Send(new GetArtistsPageQuery { StyleId = styleId, StartId = startId, Abc = abc, PageSize = pageSize });
            return Ok(response);
        }

        // =================================================================================================================
        // (U) Update
        // =================================================================================================================

        /// <summary>
        /// Update
        /// </summary>
        [HttpPut("Update")]
        [Authorize]
        [ProducesResponseType(typeof(BaseResponse), 200)]
        [ProducesResponseType(typeof(BaseResponse), 400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<BaseResponse>> Update([FromBody] UpdateArtistCommand updateArtistCommand)
        {
            var response = await _mediator.Send(updateArtistCommand);

            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        // =================================================================================================================
        // (D) Delete
        // =================================================================================================================

        /// <summary>
        /// Delete
        /// </summary>
        [HttpDelete("Delete/{businessId}")]
        [Authorize]
        [ProducesResponseType(typeof(BaseResponse), 200)]
        [ProducesResponseType(typeof(BaseResponse), 400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<BaseResponse>> Delete(Guid businessId)
        {
            var response = await _mediator.Send(new DeleteArtistCommand { BusinessId = businessId });

            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}