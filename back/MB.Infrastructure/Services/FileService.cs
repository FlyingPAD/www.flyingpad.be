using MB.Application.Contracts;

namespace MB.Infrastructure.Services;

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

    public async Task DeleteMoodAsync(string rootPath, Guid moodId, string extension)
    {
        string pathOriginal = Path.Combine(rootPath, "img", $"{moodId}.{extension}");
        string pathThumb = Path.Combine(rootPath, "img_thumbs", $"{moodId}.{extension}");

        // Utilisation de Task.Run uniquement pour la suppression de fichiers car il n'y a pas de méthode asynchrone native pour cela
        await Task.Run(() =>
        {
            if (File.Exists(pathOriginal)) File.Delete(pathOriginal);
            if (File.Exists(pathThumb)) File.Delete(pathThumb);
        });
    }
}
