using Microsoft.Extensions.FileProviders;

namespace MB.API.Configurations;

public static class StaticFilesExtensions
{
    public static IApplicationBuilder UseCustomStaticFiles(this IApplicationBuilder app)
    {
        var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
        return app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "Content")),
            RequestPath = "/Content"
        });
    }
}