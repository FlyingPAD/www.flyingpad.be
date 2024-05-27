using MB.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers;

[Route("api/V1/EMail")]
[ApiController]
[ApiExplorerSettings(GroupName = "system")]
public class EMailController(IEMailService eMailService) : Controller
{
    private readonly IEMailService _eMailService = eMailService;

    [HttpGet("MailTo")]
    public async Task<IActionResult> MailTo(string toEmail, string subject, string body)
    {
        try
        {
            await _eMailService.SendEmailAsync(toEmail, subject, body);
            return Ok("Email sent successfully to " + toEmail);
        }
        catch (Exception exception)
        {
            return BadRequest("Failed to send email. Error : " + exception);
        }
    }
}