using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Commands.CreateTag;

public class CreateTagCommandHandler(IMapper mapper, IBaseRepository<Tag> tagRepository) : IRequestHandler<CreateTagCommand, CreateTagCommandResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<CreateTagCommandResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        var createTagCommandResponse = new CreateTagCommandResponse();

        var validator = new CreateTagCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            createTagCommandResponse.Success = false;
            createTagCommandResponse.ValidationErrors = [];
            foreach (var error in validationResult.Errors)
            {
                createTagCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
            return createTagCommandResponse;
        }


        var tag = new Tag() { Name = request.Name, Description = request.Description };
        tag = await _tagRepository.CreateAsync(tag);
        createTagCommandResponse.Tag = _mapper.Map<CreateTagDto>(tag);

        return createTagCommandResponse;
    }
}
