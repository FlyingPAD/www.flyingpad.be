using MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;
using MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;
using MB.Application.Features.LinkCategories.Commands.UpdateLinkCategory;
using MB.Application.Features.LinkCategories.Queries.CountLinkCategories;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MB.API.Controllers
{
    [Route("api/V1/LinkCategories")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "features")]
    public class LinkCategoriesControllerV1(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        /// <summary>
        /// Create
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<CreateLinkCategoryCommandResponse>> Create([FromBody] CreateLinkCategoryCommand createLinkCategoryCommand)
        {
            var response = await _mediator.Send(createLinkCategoryCommand);
            return Ok(response);
        }

        /// <summary>
        /// Count
        /// </summary>
        [HttpGet("Count")]
        public async Task<ActionResult<CountLinkCategoriesQueryResponse>> Count()
        {
            var response = await _mediator.Send(new CountLinkCategoriesQuery());
            return Ok(response);
        }

        /// <summary>
        /// Get All
        /// </summary>
        [HttpGet("GetAll")]
        public async Task<ActionResult<GetLinkCategoriesListQueryResponse>> GetAll()
        {
            var response = await _mediator.Send( new GetLinkCategoriesListQuery() );
            return Ok(response);
        }

        /// <summary>
        /// Get One Details
        /// </summary>
        [HttpGet("GetOneDetails/{linkCategoryId}")]
        public async Task<ActionResult<GetLinkCategoryByIdQueryResponse>> GetOneDetails( Guid linkCategoryId)
        {
            var response = await _mediator.Send( new GetLinkCategoryByIdQuery { LinkCategoryId = linkCategoryId } );
            return Ok(response);
        }

        /// <summary>
        /// Update
        /// </summary>
        [HttpPut("Update")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<UpdateLinkCategoryCommandResponse>> Update(Guid linkCategoryId, [FromBody] UpdateLinkCategoryCommand updateLinkCategoryCommand)
        {
            if (linkCategoryId != updateLinkCategoryCommand.Id)
            {
                return BadRequest("ID in the URL does not match ID in the request body.");
            }

            var response = await _mediator.Send(updateLinkCategoryCommand);
            return Ok(response);
        }

        /// <summary>
        /// Delete
        /// </summary>
        [HttpDelete("Delete/{linkCategoryId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<DeleteLinkCategoryCommandResponse>> Delete( Guid linkCategoryId)
        {
            var response = await _mediator.Send(new DeleteLinkCategoryCommand { LinkCategoryId = linkCategoryId });
            return Ok(response);
        }
    }
}