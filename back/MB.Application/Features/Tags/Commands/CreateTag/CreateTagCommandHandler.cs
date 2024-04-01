using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Commands.CreateTag
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, CreateTagCommandResponse>
    {
        private readonly IBaseRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public CreateTagCommandHandler(IMapper mapper, IBaseRepository<Tag> tagRepository)
        {
            _mapper = mapper;
            _tagRepository = tagRepository;
        }

        public async Task<CreateTagCommandResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var createTagCommandResponse = new CreateTagCommandResponse();

            var validator = new CreateTagCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createTagCommandResponse.Success = false;
                createTagCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createTagCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createTagCommandResponse.Success)
            {
                var tag = new Tag() { Name = request.Name };
                tag = await _tagRepository.CreateAsync(tag);
                createTagCommandResponse.Tag = _mapper.Map<CreateTagDto>(tag);
            }

            return createTagCommandResponse;
        }
    }
}
