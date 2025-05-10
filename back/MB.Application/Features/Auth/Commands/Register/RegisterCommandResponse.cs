using MB.Application.Models;

namespace MB.Application.Features.Auth.Commands.Register;

public class RegisterCommandResponse : BaseResponse
{
    public string? Token { get; init; }
    public bool NeedV2 { get; init; }

    public RegisterCommandResponse(string? token)
    {
        Token = token;
        Success = token is not null;
    }
}