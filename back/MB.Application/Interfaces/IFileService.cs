namespace MB.Application.Interfaces;

public interface IFileService
{
    Task SaveImageAsync(Guid moodId, string imageData, string extension);
    Task SaveVideoAsync(Guid moodId, string videoData, string extension);
    Task DeleteMoodAsync(Guid moodId, string extension, int moodType);
}