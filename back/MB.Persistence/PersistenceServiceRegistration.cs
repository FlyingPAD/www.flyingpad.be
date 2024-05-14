using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MB.Application.Contracts.Persistence;
using MB.Persistence.Repositories;
using MB.Application.Contracts.Persistence.Common;
using MB.Persistence.Repositories.Common;
using MB.Application.Security;
using MB.Application.Contracts;
using Microsoft.Extensions.Logging;

namespace MB.Persistence
{
    public static class PersistenceServiceRegistration
    {
        /// <summary>
        /// Extends IServiceCollection 
        /// to add DB Context & Repositories to Services ( from the Persistence Project )
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(
                options => options.UseSqlServer(configuration.GetConnectionString("DB"))
                .EnableSensitiveDataLogging()
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(Console.WriteLine, LogLevel.Information)
            );

            // Common Repositories :

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseRelationRepository<>), typeof(BaseRelationRepository<>));

            // Repositories :

            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IFranchiseRepository, FranchiseRepository>();
            services.AddScoped<ILinkCategoryRepository, LinkCategoryRepository>();
            services.AddScoped<ILinkRepository, LinkRepository>();
            services.AddScoped<IMediaRepository, MediaRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IMoodRepository, MoodRepository>();
            services.AddScoped<IStyleRepository, StyleRepository>();
            services.AddScoped<ITagCategoryRepository, TagCategoryRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITaskCategoryRepository, TaskCategoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<ITokenManager, TokenManager>();

            return services;
        }
    }
}
