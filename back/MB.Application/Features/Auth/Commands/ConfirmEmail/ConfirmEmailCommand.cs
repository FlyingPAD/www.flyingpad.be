using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Auth.Commands.ConfirmEmail;

public class ConfirmEmailCommand(string token) : IRequest<BaseResponse>
{
    public string Token { get; } = token;
}