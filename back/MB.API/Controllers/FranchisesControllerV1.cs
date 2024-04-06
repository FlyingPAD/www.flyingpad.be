using MB.Application.Features.Franchises.Commands.CreateFranchise;
using MB.Application.Features.Franchises.Commands.DeleteFranchise;
using MB.Application.Features.Franchises.Commands.UpdateFranchise;
using MB.Application.Features.Franchises.Queries.CountFranchises;
using MB.Application.Features.Franchises.Queries.GetFranchiseById;
using MB.Application.Features.Franchises.Queries.GetFranchisesByModel;
using MB.Application.Features.Franchises.Queries.GetFranchisesByMood;
using MB.Application.Features.Franchises.Queries.GetFranchisesList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers
{
    [Route("api/V1/Franchises")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "features")]
    public class FranchisesControllerV1(IMediator mediator) : ControllerBase
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
        public async Task<ActionResult<CreateFranchiseCommandResponse>> Create([FromBody] CreateFranchiseCommand createFranchiseCommand)
        {
            var response = await _mediator.Send(createFranchiseCommand);
            return Ok(response);
        }

        // =================================================================================================================
        // (R) Retrieve
        // =================================================================================================================

        /// <summary>
        /// Count
        /// </summary>
        [HttpGet("Count")]
        public async Task<ActionResult<CountFranchisesQueryResponse>> Count()
        {
            var response = await _mediator.Send(new CountFranchisesQuery());
            return Ok(response);
        }
        
        /// <summary>
        /// Get All
        /// </summary>
        [HttpGet("GetAll")]
        public async Task<ActionResult<GetAllFranchisesQueryResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetAllFranchisesQuery());
            return Ok(response);
        }

        /// <summary>
        /// Get One
        /// </summary>
        [HttpGet("GetOneDetails/{businessId}")]
        public async Task<ActionResult<GetFranchiseByIdQueryResponse>> GetOne(Guid businessId)
        {
            var response = await _mediator.Send(new GetFranchiseByIdQuery { BusinessId = businessId });
            return Ok(response);
        }

        /// <summary>
        /// Get By Mood
        /// </summary>
        /// <param name="businessId"></param>
        /// <returns></returns>
        [HttpGet("GetByMood/{businessId}")]
        public async Task<ActionResult<GetFranchisesByMoodQueryResponse>> GetByMood(Guid businessId)
        {
            var response = await _mediator.Send(new GetFranchisesByMoodQuery { BusinessId = businessId });
            return Ok(response);
        }

        /// <summary>
        /// Get By Model
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        [HttpGet("GetByModel/{modelId}")]
        public async Task<ActionResult<GetFranchisesByModelQueryResponse>> GetByModel(Guid modelId)
        {
            var response = await _mediator.Send(new GetFranchisesByModelQuery { ModelId = modelId });
            return Ok(response);
        }

        /// <summary>
        /// Get Franchises With Categories & Models ( Full List )
        /// </summary>
        [HttpGet("GetFranchisesList")]
        public async Task<ActionResult<GetFranchisesListQueryResponse>> GetFranchisesList()
        {
            var response = await _mediator.Send(new GetFranchisesListQuery());
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
        public async Task<ActionResult<UpdateFranchiseCommandResponse>> Update(Guid FranchiseId, [FromBody] UpdateFranchiseCommand updateFranchiseCommand)
        {
            if (FranchiseId != updateFranchiseCommand.Id)
            {
                return BadRequest("ID in the URL does not match ID in the request body.");
            }

            var response = await _mediator.Send(updateFranchiseCommand);
            return Ok(response);
        }

        // =================================================================================================================
        // (D) Delete
        // =================================================================================================================

        /// <summary>
        /// Delete
        /// </summary>
        [HttpDelete("Delete/{franchiseId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<DeleteFranchiseCommandResponse>> Delete(Guid franchiseId)
        {
            var response = await _mediator.Send(new DeleteFranchiseCommand { FranchiseId = franchiseId });
            return Ok(response);
        }
    }
}