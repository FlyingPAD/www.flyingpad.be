namespace MB.Infrastructure.Configurations;

public static class DirectoriesConfiguration
{
    public static void CheckDirectories()
    {
        var paths = new List<string>
        {
            @"Content",
            @"Content/img",
            @"Content/img_thumbs",
            @"Content/video",
            @"Content/video_thumbs",
            @"Content/txt",
            @"Content/txt_thumbs",
        };

        foreach (var path in paths)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error creating directory {path}: {e}");
            }
        }
    }
}