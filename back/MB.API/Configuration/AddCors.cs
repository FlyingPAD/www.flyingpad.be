namespace MB.API.Configuration;

// Configure Cross-Origin Resource Sharing (CORS).
public static class AddCors
{
    public static void Configuration(IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("Open", builder => builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
        });
    }
}