﻿using MB.Application.Features.Images.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Images")]
[ApiController]
[ApiExplorerSettings(GroupName = "extensions")]
public class ImageControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("GetOneDetails/{imageId}")]
    public async Task<ActionResult<GetOneImageDetailsQueryResponse>> GetOneDetails(Guid imageId)
        => Ok(await _mediator.Send(new GetOneImageDetailsQuery { ImageId = imageId }));
}