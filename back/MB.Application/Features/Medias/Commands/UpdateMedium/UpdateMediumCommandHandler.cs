using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.MediumAggregate;
using MediatR;

namespace MB.Application.Features.Medias.Commands.UpdateMedium;

public class UpdateMediumCommandHandler(IBaseRepository<Media> mediaRepository) : IRequestHandler<UpdateMediumCommand, BaseResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;

    public async Task<BaseResponse> Handle(UpdateMediumCommand request, CancellationToken cancellationToken)
    {
        var medium = await _mediaRepository.GetByBusinessIdAsync(request.MediumId)
            ?? throw new NotFoundException("Medium not found.");

        medium.Name = request.Name;
        medium.Description = request.Description;

        await _mediaRepository.UpdateAsync(medium);

        return new BaseResponse
        {
            Success = true,
            Message = "Medium was updated.",
        };
    }
}