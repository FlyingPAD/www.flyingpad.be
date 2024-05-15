using AutoMapper;
using MB.Application.Contracts;
using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMoodImage
{
    public class CreateMoodImageCommandHandler(
        IFileService fileService,
        IBaseRepository<Image> imageRepository,
        ITagRepository tagRepository,
        IMapper mapper,
        IBaseRepository<RelationMoodTag> relationRepository) : IRequestHandler<CreateMoodImageCommand, CreateMoodImageCommandResponse>
    {
        private readonly IFileService _fileService = fileService;
        private readonly IBaseRepository<Image> _imageRepository = imageRepository;
        private readonly IBaseRepository<RelationMoodTag> _relationRepository = relationRepository;
        private readonly ITagRepository _tagRepository = tagRepository;
        private readonly IMapper _mapper = mapper;

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
                Type = 1
            };

            // Insert Image Data into DB
            var createdImage = await _imageRepository.CreateAsync(image);

            // Copy File on Server
            await _fileService.SaveImageAsync(createdImage.BusinessId, request.SourceFile, request.Extension);

            // Get Tags
            var tagImage = await _tagRepository.GetByName("Image");
            var tagAllFiles = await _tagRepository.GetByName("# All Files");
            var tagSquare = await _tagRepository.GetByName("Square");
            var tagLandscape = await _tagRepository.GetByName("Landscape");
            var tagLandscape169 = await _tagRepository.GetByName("Landscape (16:9)");
            var tagPortrait = await _tagRepository.GetByName("Portrait");
            var tagPortrait169 = await _tagRepository.GetByName("Portrait (16:9)");
            var tagbmp = await _tagRepository.GetByName(".bmp");
            var taggif = await _tagRepository.GetByName(".gif");
            var tagjpeg = await _tagRepository.GetByName(".jpeg");
            var tagjpg = await _tagRepository.GetByName(".jpg");
            var tagpng = await _tagRepository.GetByName(".png");
            var tagwebp = await _tagRepository.GetByName(".webp");

            if (tagImage != null && tagAllFiles != null)
            {
                // Create Tag List
                var tags = new List<int>
                {
                    tagImage.EntityId,
                    tagAllFiles.EntityId
                };

                // Add dimension-specific tags based on image dimensions
                if (tagSquare != null && request.Height == request.Width)
                {
                    tags.Add(tagSquare.EntityId);
                }
                if (tagPortrait != null && request.Height > request.Width)
                {
                    tags.Add(tagPortrait.EntityId);
                }
                if (tagLandscape != null && request.Height < request.Width)
                {
                    tags.Add(tagLandscape.EntityId);
                }
                if (tagLandscape169 != null && ((float)request.Height / request.Width) == (16f / 9))
                {
                    tags.Add(tagLandscape169.EntityId);
                }
                if (tagPortrait169 != null && ((float)request.Width / request.Height) == (16f / 9))
                {
                    tags.Add(tagPortrait169.EntityId);
                }

                // Add format-specific tags
                if (tagbmp != null && request.Extension == "bmp")
                {
                    tags.Add(tagbmp.EntityId);
                }
                if (taggif != null && request.Extension == "gif")
                {
                    tags.Add(taggif.EntityId);
                }
                if (tagjpeg != null && request.Extension == "jpeg")
                {
                    tags.Add(tagjpeg.EntityId);
                }
                if (tagjpg != null && request.Extension == "jpg")
                {
                    tags.Add(tagjpg.EntityId);
                }
                if (tagpng != null && request.Extension == "png")
                {
                    tags.Add(tagpng.EntityId);
                }
                if (tagwebp != null && request.Extension == "webp")
                {
                    tags.Add(tagwebp.EntityId);
                }

                // Insert Tags
                foreach (var tag in tags)
                {
                    var moodTag = new RelationMoodTag
                    {
                        MoodId = createdImage.EntityId,
                        TagId = tag
                    };
                    await _relationRepository.CreateAsync(moodTag);
                }
            }

            var response = new CreateMoodImageCommandResponse
            {
                Mood = _mapper.Map<CreateMoodImageCommandDto>(createdImage),
                Success = true,
                Message = "Image created successfully."
            };

            return response;
        }
    }
}