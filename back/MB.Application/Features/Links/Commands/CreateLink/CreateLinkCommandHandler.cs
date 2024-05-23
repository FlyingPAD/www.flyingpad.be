using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommandHandler(IMapper mapper, IBaseRepository<Link> linkRepository) : IRequestHandler<CreateLinkCommand, CreateLinkCommandResponse>
{
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<CreateLinkCommandResponse> Handle(CreateLinkCommand request, CancellationToken cancellationToken)
    {
        var createLinkCommandResponse = new CreateLinkCommandResponse();

        var validator = new CreateLinkCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            createLinkCommandResponse.Success = false;

            foreach (var error in validationResult.Errors)
            {
                createLinkCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }

            return createLinkCommandResponse;
        }


        var link = new Link() 
        { 
            Name = request.Name, 
            Description = request.Description,
            Url = request.Url
        };

        link = await _linkRepository.CreateAsync(link);
        createLinkCommandResponse.Link = _mapper.Map<CreateLinkDto>(link);

        return createLinkCommandResponse;
    }
}
