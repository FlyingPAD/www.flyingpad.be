namespace MB.Application.Contracts
{
    /// <summary>
    /// Provides functionality to save images to the file system.
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Asynchronously saves an image to the file system.
        /// </summary>
        /// <param name="moodId">The identifier for the mood with which the image is associated.</param>
        /// <param name="imageData">The image data in Base64 format.</param>
        /// <param name="extension">The file extension for the image file (e.g., "jpg", "png").</param>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        Task SaveImageAsync(Guid moodId, string imageData, string extension);
    }
}