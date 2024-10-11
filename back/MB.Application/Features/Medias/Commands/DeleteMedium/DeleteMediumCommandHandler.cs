using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Commands.DeleteMedium;

public class DeleteMediumCommandHandler(IBaseRepository<Media> mediaRepository) : IRequestHandler<DeleteMediumCommand, BaseResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;

    public async Task<BaseResponse> Handle(DeleteMediumCommand request, CancellationToken cancellationToken)
    {
        var medium = await _mediaRepository.GetByBusinessIdAsync(request.MediumId) 
            ?? throw new NotFoundException($"Medium not found.");

        await _mediaRepository.DeleteAsync(medium);

        return new BaseResponse
        {
            Success = true,
            Message = "Medium was deleted."
        };
    }
}