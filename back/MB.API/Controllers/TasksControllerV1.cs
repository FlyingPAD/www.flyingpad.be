﻿using MB.Application.Features.Tasks.Commands.CreateTask;
using MB.Application.Features.Tasks.Commands.DeleteTask;
using MB.Application.Features.Tasks.Commands.UpdateTask;
using MB.Application.Features.Tasks.Queries.GetTaskDetails;
using MB.Application.Features.Tasks.Queries.GetTasksList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Tasks")]
[ApiController]
[ApiExplorerSettings(GroupName = "features")]
public class TasksControllerV1(IMediator mediator) : Controller
{
    private readonly IMediator _mediator = mediator;

    [HttpGet(Name = "GetAllTasks")]
    public async Task<ActionResult<List<TasksListVm>>> GetAllTasks()
    {
        var dtos = await _mediator.Send(new GetTasksListQuery());
        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "GetTaskById")]
    public async Task<ActionResult<TaskDetailsVm>> GetTaskById(Guid id)
    {
        var getTaskDetailsQuery = new GetTaskDetailsQuery() { Id = id };
        return Ok(await _mediator.Send(getTaskDetailsQuery));
    }

    [HttpPost(Name = "AddTask")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<Guid>> Create([FromBody] CreateTaskCommand createTaskCommand)
    {
        var id = await _mediator.Send(createTaskCommand);
        return Ok(id);
    }

    [HttpPut(Name = "UpdateTask")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult> Update([FromBody] UpdateTaskCommand updateTaskCommand)
    {
        await _mediator.Send(updateTaskCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteTask")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleteTaskCommand = new DeleteTaskCommand() { Id = id };
        await _mediator.Send(deleteTaskCommand);
        return NoContent();
    }
}
