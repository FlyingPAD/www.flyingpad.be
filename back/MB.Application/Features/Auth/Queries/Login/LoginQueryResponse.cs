﻿using MB.Application.Models;

namespace MB.Application.Features.Auth.Queries.Login;

public class LoginQueryResponse(string? token) : BaseResponse()
{
    public string? Token { get; init; } = token;
}