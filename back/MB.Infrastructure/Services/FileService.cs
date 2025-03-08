using MB.Application.Interfaces.Infrastructure;
using System.Diagnostics;

namespace MB.Infrastructure.Services;

public class FileService : IFileService
{
    public async Task SaveImageAsync(Guid moodId, string imageData, string extension)
    {
        string base64Image = ExtractBase64Data(imageData);
        string imagePath = GetFilePath("img", moodId, extension);
        string thumbPath = GetFilePath("img_thumbs", moodId, extension);

        await SaveFileAsync(base64Image, imagePath);
        await GenerateThumbnailForImage(imagePath, thumbPath);
    }

    public async Task SaveVideoAsync(Guid moodId, string videoData, string extension)
    {
        string ffmpegPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "MB.Infrastructure", "Libraries", "bin", "ffmpeg.exe");

        if (!File.Exists(ffmpegPath))
        {
            throw new FileNotFoundException($"FFmpeg not found at {ffmpegPath}");
        }

        string base64Video = ExtractBase64Data(videoData);
        string videoPath = GetFilePath("video", moodId, extension);
        string thumbPath = GetFilePath("video_thumbs", moodId, "jpg");

        await SaveFileAsync(base64Video, videoPath);
        await GenerateThumbnailForVideoAsync(ffmpegPath, videoPath, thumbPath);
    }

    public async Task DeleteMoodAsync(Guid moodId, string extension, int moodType)
    {
        if (moodType == 1)
        {
            await DeleteImageFileAsync(moodId, extension);
            await DeleteImageThumbnailAsync(moodId, extension);
        }
        else if (moodType == 2)
        {
            await DeleteVideoFileAsync(moodId, extension);
            await DeleteVideoThumbnailAsync(moodId);
        }
    }

    private static async Task DeleteImageFileAsync(Guid moodId, string extension)
    {
        string imagePath = GetFilePath("img", moodId, extension);
        await DeleteFileAsync(imagePath);
    }

    private static async Task DeleteImageThumbnailAsync(Guid moodId, string extension)
    {
        string thumbPath = GetFilePath("img_thumbs", moodId, extension);
        await DeleteFileAsync(thumbPath);
    }

    private static async Task DeleteVideoFileAsync(Guid moodId, string extension)
    {
        string videoPath = GetFilePath("video", moodId, extension);
        await DeleteFileAsync(videoPath);
    }

    private static async Task DeleteVideoThumbnailAsync(Guid moodId)
    {
        string thumbPath = GetFilePath("video_thumbs", moodId, "jpg");
        await DeleteFileAsync(thumbPath);
    }

    private static async Task DeleteFileAsync(string filePath)
    {
        await Task.Run(() =>
        {
            if (File.Exists(filePath)) File.Delete(filePath);
        });
    }

    private static async Task SaveFileAsync(string base64Data, string filePath)
    {
        byte[] fileBytes = Convert.FromBase64String(base64Data);
        await WriteFileAsync(filePath, fileBytes);
    }

    private static async Task WriteFileAsync(string path, byte[] fileBytes)
    {
        await File.WriteAllBytesAsync(path, fileBytes);
    }

    private static async Task GenerateThumbnailForVideoAsync(string ffmpegPath, string videoPath, string thumbnailPath)
    {
        string inputOptions = $"-i \"{videoPath}\"";
        string outputOptions = $"-ss 00:00:01.000 -vframes 1 \"{thumbnailPath}\"";

        var processInfo = new ProcessStartInfo(ffmpegPath, $"{inputOptions} {outputOptions}")
        {
            CreateNoWindow = true,
            UseShellExecute = false,
            RedirectStandardError = true,
            RedirectStandardOutput = true
        };

        using (var process = Process.Start(processInfo))
        {
            if (process != null)
            {
                string errors = await process.StandardError.ReadToEndAsync();
                string output = await process.StandardOutput.ReadToEndAsync();

                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"Erreur lors de la génération de la vignette pour la vidéo : {errors}");
                }
            }
            else
            {
                throw new Exception("Impossible de démarrer le processus FFmpeg.");
            }
        }
    }

    private static async Task GenerateThumbnailForImage(string imagePath, string thumbnailPath)
    {
        if (File.Exists(imagePath))
        {
            await Task.Run(() =>
            {
                File.Copy(imagePath, thumbnailPath, overwrite: true);
            });
        }
    }

    private static string ExtractBase64Data(string base64Data)
    {
        return base64Data.Contains(',') ? base64Data.Split(",")[1] : base64Data;
    }

    private static string GetFilePath(string folder, Guid moodId, string extension)
    {
        return Path.Combine("Content", folder, $"{moodId}.{extension}");
    }
}