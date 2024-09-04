using MB.Application;
using MB.Application.Contracts;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Common;
using MB.Persistence.Repositories;
using MB.Persistence.Repositories.Common;
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

        services.AddScoped<IArtistRepository, ArtistRepository>();
        services.AddScoped<IFranchiseRepository, FranchiseRepository>();
        services.AddScoped<ILinkCategoryRepository, LinkCategoryRepository>();
        services.AddScoped<ILinkRepository, LinkRepository>();
        services.AddScoped<IMediaRepository, MediaRepository>();
        services.AddScoped<IModelRepository, ModelRepository>();
        services.AddScoped<IMoodRepository, MoodRepository>();
        services.AddScoped<IStyleRepository, StyleRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<ITaskCategoryRepository, TaskCategoryRepository>();
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<ITokenManager, TokenManager>();

        return services;
    }
}