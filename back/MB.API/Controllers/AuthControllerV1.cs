using MB.Application.Features.Auth.Commands.ConfirmEmail;
using MB.Application.Features.Auth.Commands.Register;
using MB.Application.Features.Auth.Commands.SendVerificationEmail;
using MB.Application.Features.Auth.Queries.Login;
using MB.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        => Ok(await _mediator.Send(loginQuery));


    [HttpPost("Register")]
    public async Task<ActionResult<RegisterCommandResponse>> Register([FromBody] RegisterCommand registerCommand)
        => Ok(await _mediator.Send(registerCommand));


    [HttpPost("SendVerificationEmail")]
    [Authorize]
    public async Task<ActionResult<BaseResponse>> SendVerificationEmail()
        => Ok(await _mediator.Send(new SendVerificationEmailCommand()));


    [HttpPost("ConfirmEmail")]
    [AllowAnonymous]
    public async Task<ActionResult<BaseResponse>> ConfirmEmail([FromBody] ConfirmEmailCommand cmd)
        => Ok(await _mediator.Send(cmd));
}