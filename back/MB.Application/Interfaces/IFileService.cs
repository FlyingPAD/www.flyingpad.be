namespace MB.Application.Contracts;

public interface IFileService
{
    Task SaveImageAsync(Guid moodId, string imageData, string extension);
    Task DeleteMoodAsync(string path, Guid moodId, string extension);
}