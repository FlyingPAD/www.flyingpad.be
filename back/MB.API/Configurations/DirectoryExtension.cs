using MB.Infrastructure.Configurations;

namespace MB.API.Configurations;

public static class DirectoryExtensions
{
    public static IHost CheckRequiredDirectories(this IHost host)
    {
        DirectoriesConfiguration.CheckDirectories();
        return host;
    }
}