using MediatR;

namespace MB.Application.Features.Auth.Commands.Register;

public class RegisterCommand : IRequest<RegisterCommandResponse>
{
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime? Birthdate { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Pass { get; set; } = string.Empty;
    public string ConfirmPass { get; set; } = string.Empty;
    public string CaptchaToken { get; set; } = string.Empty;
    public string CaptchaType { get; set; } = "v3";
}