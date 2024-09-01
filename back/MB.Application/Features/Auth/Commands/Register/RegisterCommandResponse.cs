using MB.Application.Models;

namespace MB.Application.Features.Auth.Commands.Register;

public class RegisterCommandResponse(string? token) : BaseResponse()
{
    public string? Token { get; init; } = token;
}