using MB.Application.Features.Auth.Commands.Register;
using MB.Application.Features.Auth.Queries.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MB.API.Controllers
{
    [Route("api/V1/Auth")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "system")]
    public class AuthControllerV1(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        /// <summary>
        /// Login
        /// </summary>
        [HttpPost("Login")]
        public async Task<ActionResult<LoginQueryResponse>> Login([FromBody] LoginQuery loginQuery)
        {
            var response = await _mediator.Send(loginQuery);
            return Ok(response);
        }

        /// <summary>
        /// Register
        /// </summary>
        [HttpPost("Register")]
        public async Task<ActionResult<RegisterCommandResponse>> Register([FromBody] RegisterCommand registerCommand)
        {
            var response = await _mediator.Send(registerCommand);
            return Ok(response);
        }
    }
}