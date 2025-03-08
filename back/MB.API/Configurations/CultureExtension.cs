using System.Globalization;

namespace MB.API.Configurations;

public static class CultureExtensions
{
    public static void ConfigureDefaultCulture(this WebApplicationBuilder builder, string culture = "en-US")
    {
        var defaultCulture = new CultureInfo(culture);
        CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
        CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;
    }
}