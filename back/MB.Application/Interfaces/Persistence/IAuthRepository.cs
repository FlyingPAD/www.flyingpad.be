﻿using MB.Domain.UserAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface IAuthRepository
{
    Task<User?> LoginAsync(string email, string password);
    Task<User> RegisterAsync(User user, string password);
    Task<bool> UserExists(string email);
}