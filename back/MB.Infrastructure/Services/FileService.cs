using MB.Application.Contracts;

namespace MB.Infrastructure.Services
{
    public class FileService : IFileService
    {
        public async Task SaveImageAsync(Guid moodId, string imageData, string extension)
        {
            string base64Image = imageData.Contains(',') ? imageData.Split(",")[1] : imageData;
            await ConvertTobase64Async(base64Image, "Content", moodId, extension);
        }

        private static async Task ConvertTobase64Async(string base64Image, string rootPath, Guid moodId, string ext)
        {
            byte[] imageBytes = Convert.FromBase64String(base64Image);

            string pathOriginal = Path.Combine(rootPath, "img", $"{moodId}.{ext}");
            await File.WriteAllBytesAsync(pathOriginal, imageBytes);

            string pathThumb = Path.Combine(rootPath, "img_thumbs", $"{moodId}.{ext}");
            await File.WriteAllBytesAsync(pathThumb, imageBytes);
        }
    }
}