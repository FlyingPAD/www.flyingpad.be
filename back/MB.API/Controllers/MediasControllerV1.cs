using MB.Application.Features.Medias.Commands.CreateMedia;
using MB.Application.Features.Medias.Commands.DeleteMedia;
using MB.Application.Features.Medias.Commands.UpdateMedia;
using MB.Application.Features.Medias.Queries.CountMedias;
using MB.Application.Features.Medias.Queries.GetMediaById;
using MB.Application.Features.Medias.Queries.GetMediasList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers
{
    [Route("api/V1/Medias")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "features")]
    public class MediasControllerV1(IMediator mediator) : ControllerBase
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
        public async Task<ActionResult<CreateMediaCommandResponse>> Create([FromBody] CreateMediaCommand createMediaCommand)
        {
            var response = await _mediator.Send(createMediaCommand);
            return Ok(response);
        }

        // =================================================================================================================
        // (R) Retrieve
        // =================================================================================================================

        /// <summary>
        /// Count
        /// </summary>
        [HttpGet("Count")]
        public async Task<ActionResult<CountMediasQueryResponse>> Count()
        {
            var response = await _mediator.Send(new CountMediasQuery());
            return Ok(response);
        }

        /// <summary>
        /// Get All
        /// </summary>
        [HttpGet("GetAll")]
        public async Task<ActionResult<GetMediasListQueryResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetMediasListQuery());
            return Ok(response);
        }

        /// <summary>
        /// Get One
        /// </summary>
        [HttpGet("GetOne/{mediaId}")]
        public async Task<ActionResult<GetMediaByIdQuery>> GetOne(Guid mediaId)
        {
            var response = await _mediator.Send(new GetMediaByIdQuery { MediaId = mediaId });
            return Ok(response);
        }

        // =================================================================================================================
        // (U) Update
        // =================================================================================================================

        /// <summary>
        /// Update
        /// </summary>
        [HttpPut("Update")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<UpdateMediaCommandResponse>> Update(Guid mediaId, [FromBody] UpdateMediaCommand updateMediaCommand)
        {
            if (mediaId != updateMediaCommand.Id)
            {
                return BadRequest("ID in the URL does not match ID in the request body.");
            }

            var response = await _mediator.Send(updateMediaCommand);
            return Ok(response);
        }

        // =================================================================================================================
        // (D) Delete
        // =================================================================================================================

        /// <summary>
        /// Delete
        /// </summary>
        [HttpDelete("Delete/{mediaId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<DeleteMediaCommandResponse>> Delete(Guid mediaId)
        {
            var response = await _mediator.Send(new DeleteMediaCommand { MediaId = mediaId });
            return Ok(response);
        }
    }
}