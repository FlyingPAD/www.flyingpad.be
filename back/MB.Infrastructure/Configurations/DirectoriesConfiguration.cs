namespace MB.Infrastructure.Configurations
{
    public static class DirectoriesConfiguration
    {
        public static void CheckDirectories()
        {
            List<string> paths = new();

            paths.Add(@"Content");
            paths.Add(@"Content/img");
            paths.Add(@"Content/img_thumbs");
            paths.Add(@"Content/video");
            paths.Add(@"Content/video_thumbs");
            paths.Add(@"Content/txt");
            paths.Add(@"Content/txt_thumbs");

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
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}