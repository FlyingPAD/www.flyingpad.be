using MB.Application.Interfaces.Infrastructure;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.MoodAggregate;
using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMoodImage;

public class CreateMoodImageCommandHandler(
    IFileService fileService,
    IBaseRepository<Image> imageRepository,
    IMoodRepository moodRepository) : IRequestHandler<CreateMoodImageCommand, CreateMoodImageCommandResponse>
{
    private readonly IFileService _fileService = fileService;
    private readonly IBaseRepository<Image> _imageRepository = imageRepository;
    private readonly IMoodRepository _moodRepository = moodRepository;

    public async Task<CreateMoodImageCommandResponse> Handle(CreateMoodImageCommand request, CancellationToken cancellationToken)
    {
        var image = new Image
        {
            Name = request.Name,
            Description = request.Description,
            Size = request.Size,
            Extension = request.Extension,
            Height = request.Height,
            Width = request.Width,
            Type = 1,
            Score = 0,
        };

        var createdImage = await _imageRepository.CreateAsync(image);
        await _fileService.SaveImageAsync(createdImage.BusinessId, request.SourceFile, request.Extension);
        await _moodRepository.AddImageSpecificTags(image);

        var response = new CreateMoodImageCommandResponse
        {
            MoodId = createdImage.BusinessId,
            Success = true,
            Message = "Image created successfully."
        };

        return response;
    }
}