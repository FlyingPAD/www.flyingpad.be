using MB.Application.Features.Auth.Commands.Register;
using MB.Application.Features.Auth.Queries.Login;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Auth")]
[ApiController]
[ApiExplorerSettings(GroupName = "system")]
public class AuthControllerV1(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginQuery loginQuery)
    {
        LoginQueryResponse response = await _mediator.Send(loginQuery);

        if (response.Success)
        {
            return Ok(response);
        }
        else
        {
            return BadRequest("An error occurred during the login process.");
        }
    }

    [HttpPost("Register")]
    public async Task<ActionResult<RegisterCommandResponse>> Register([FromBody] RegisterCommand registerCommand)
        => Ok(await _mediator.Send(registerCommand));
}