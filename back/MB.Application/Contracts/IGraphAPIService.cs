﻿namespace MB.Application.Contracts;

public interface IGraphAPIService
{
    Task<IEnumerable<AzureUserDto>> GetUsersAsync();
}
