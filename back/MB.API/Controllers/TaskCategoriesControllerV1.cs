using MB.Application.Features.TaskCategories.Commands.CreateTaskCategory;
using MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesList;
using MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesListWithTasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers
{
    [Route("api/V1/TaskCategories")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "features")]
    public class TaskCategoriesControllerV1(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet("all", Name = "GetAllTaskCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<TaskCategoryListVm>>> GetAllTaskCategories()
        {
            var dtos = await _mediator.Send(new GetTaskCategoriesListQuery());
            return Ok(dtos);
        }

        [HttpGet("allwithtasks", Name = "GetTaskCategoriesWithTasks")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<TaskCategoryTaskListVm>>> GetTaskCategoriesWithTasks(bool includeHistory)
        {
            GetTaskCategoriesListWithTasksQuery getTaskCategoriesListWithEventsQuery = new GetTaskCategoriesListWithTasksQuery() { IncludeHistory = includeHistory };

            var dtos = await _mediator.Send(getTaskCategoriesListWithEventsQuery);
            return Ok(dtos);
        }

        [HttpPost(Name = "AddTaskCategory")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<CreateTaskCategoryCommandResponse>> Create([FromBody] CreateTaskCategoryCommand createTaskCategoryCommand)
        {
            var response = await _mediator.Send(createTaskCategoryCommand);
            return Ok(response);
        }
    }
}
