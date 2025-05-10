using MB.Application.Interfaces.Persistence;
using MB.Persistence.Repositories;
using MB.Persistence.Repositories.Definitions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MB.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<Context>(
            options => options.UseSqlServer(configuration.GetConnectionString("DB"))
            .EnableSensitiveDataLogging()
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
            .LogTo(Console.WriteLine, LogLevel.Information)
        );

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        services.AddScoped<IAchievementDefinitionsRepository, AchievementDefinitionsRepository>();
        services.AddScoped<IArtistRepository, ArtistRepository>();
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IEmailVerificationTokenRepository, EmailVerificationTokenRepository>();
        services.AddScoped<IFranchiseRepository, FranchiseRepository>();
        services.AddScoped<ILinkCategoryRepository, LinkCategoryRepository>();
        services.AddScoped<ILinkRepository, LinkRepository>();
        services.AddScoped<IMediaRepository, MediaRepository>();
        services.AddScoped<IModelRepository, ModelRepository>();
        services.AddScoped<IMoodRepository, MoodRepository>();
        services.AddScoped<ISeasonRepository, SeasonRepository>();
        services.AddScoped<IStyleRepository, StyleRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<ITaskCategoryRepository, TaskCategoryRepository>();
        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<IUserAchievementRepository, UserAchievementRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}