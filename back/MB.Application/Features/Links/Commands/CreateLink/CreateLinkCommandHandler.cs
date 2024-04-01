using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Commands.CreateLink
{
    public class CreateLinkCommandHandler : IRequestHandler<CreateLinkCommand, CreateLinkCommandResponse>
    {
        private readonly IBaseRepository<Link> _linkRepository;
        private readonly IMapper _mapper;

        public CreateLinkCommandHandler(IMapper mapper, IBaseRepository<Link> linkRepository)
        {
            _mapper = mapper;
            _linkRepository = linkRepository;
        }

        public async Task<CreateLinkCommandResponse> Handle(CreateLinkCommand request, CancellationToken cancellationToken)
        {
            var createLinkCommandResponse = new CreateLinkCommandResponse();

            var validator = new CreateLinkCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createLinkCommandResponse.Success = false;
                createLinkCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createLinkCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createLinkCommandResponse.Success)
            {
                var link = new Link() { Name = request.Name };
                link = await _linkRepository.CreateAsync(link);
                createLinkCommandResponse.Link = _mapper.Map<CreateLinkDto>(link);
            }

            return createLinkCommandResponse;
        }
    }
}
