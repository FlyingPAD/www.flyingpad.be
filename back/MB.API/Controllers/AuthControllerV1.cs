using MB.Application.Contracts;
using MB.Application.Features.Auth.Commands.Register;
using MB.Application.Features.Auth.Queries.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/Auth")]
[ApiController]
[ApiExplorerSettings(GroupName = "system")]
public class AuthControllerV1(IMediator mediator, IEMailService eMailService) : ControllerBase
{
    private readonly IMediator _mediator = mediator;
    private readonly IEMailService _eMailService = eMailService;

    [HttpPost("Login")]
    public async Task<ActionResult<LoginQueryResponse>> Login([FromBody] LoginQuery loginQuery)
    {
        var response = await _mediator.Send(loginQuery);
        return Ok(response);
    }

    [HttpPost("Register")]
    public async Task<ActionResult<RegisterCommandResponse>> Register([FromBody] RegisterCommand registerCommand)
    {
        var response = await _mediator.Send(registerCommand);
        return Ok(response);
    }

    [HttpGet("Test")]
    public async Task<IActionResult> SendTestEmail()
    {
        try
        {
            string toEmail = "tonyvan@live.fr";
            string subject = "Email from Flying PAD";
            string body = "Test";

            await _eMailService.SendEmailAsync(toEmail, subject, body);
            return Ok("Email sent successfully to " + toEmail);
        }
        catch (Exception ex)
        {
            return BadRequest("Failed to send email. Error: " + ex.Message);
        }
    }
}