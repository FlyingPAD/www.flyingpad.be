﻿using MB.Domain.UserAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
    Task<User?> GetByIdAsync(int id);
    Task<IList<User>> GetAllWithAchievementsAsync();
    Task<User?> GetByBusinessIdWithAchievementsAsync(Guid businessId);
    Task<IList<User>> GetAllWithLeagueAsync();
    Task<User?> GetByBusinessIdFullAsync(Guid businessId);
    Task UpdateAggregateAsync(User user);
}