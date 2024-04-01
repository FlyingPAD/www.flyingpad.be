using MB.Application.Features.TagCategories.Commands.CreateTagCategory;
using MB.Application.Features.TagCategories.Commands.DeleteTagCategory;
using MB.Application.Features.TagCategories.Commands.UpdateTagCategory;
using MB.Application.Features.TagCategories.Queries.CountTagCategories;
using MB.Application.Features.TagCategories.Queries.GetTagCategoryById;
using MB.Application.Features.TagCategories.Queries.GetTagCategoriesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MB.API.Controllers
{
    [Route("api/V1/TagCategories")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "features")]
    public class TagCategoriesControllerV1(IMediator mediator) : ControllerBase
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
        public async Task<ActionResult<CreateTagCategoryCommandResponse>> Create([FromBody] CreateTagCategoryCommand createTagCategoryCommand)
        {
            var response = await _mediator.Send(createTagCategoryCommand);
            return Ok(response);
        }

        // =================================================================================================================
        // (R) Retrieve
        // =================================================================================================================

        /// <summary>
        /// Count
        /// </summary>
        [HttpGet("Count")]
        public async Task<ActionResult<CountTagCategoriesQueryResponse>> Count()
        {
            var response = await _mediator.Send(new CountTagCategoriesQuery());
            return Ok(response);
        }

        /// <summary>
        /// Get All
        /// </summary>
        [HttpGet("GetAll")]
        public async Task<ActionResult<GetTagCategoriesListQueryResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetTagCategoriesListQuery());
            return Ok(response);
        }

        /// <summary>
        /// Get One
        /// </summary>
        [HttpGet("GetOne/{tagCategoryId}")]
        public async Task<ActionResult<GetTagCategoryByIdQuery>> GetOne(Guid tagCategoryId)
        {
            var response = await _mediator.Send(new GetTagCategoryByIdQuery { Id = tagCategoryId });
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
        public async Task<ActionResult<UpdateTagCategoryCommandResponse>> Update(Guid tagCategoryId, [FromBody] UpdateTagCategoryCommand updateTagCategoryCommand)
        {
            if (tagCategoryId != updateTagCategoryCommand.Id)
            {
                return BadRequest("ID in the URL does not match ID in the request body.");
            }

            var response = await _mediator.Send(updateTagCategoryCommand);
            return Ok(response);
        }

        // =================================================================================================================
        // (D) Delete
        // =================================================================================================================

        /// <summary>
        /// Delete
        /// </summary>
        [HttpDelete("Delete/{tagCategoryId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<DeleteTagCategoryCommandResponse>> Delete(Guid tagCategoryId)
        {
            var response = await _mediator.Send(new DeleteTagCategoryCommand { Id = tagCategoryId });
            return Ok(response);
        }
    }
}