using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Tags.Commands.DeleteTag;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommand, DeleteTagCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Tag> _tagRepository;

        public DeleteTagCommandHandler(IMapper mapper, IBaseRepository<Tag> tagRepository)
        {
            _mapper = mapper;
            _tagRepository = tagRepository;
        }

        public async Task<DeleteTagCommandResponse> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            var deleteTagCommandResponse = new DeleteTagCommandResponse();

            var validator = new DeleteTagCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                deleteTagCommandResponse.Success = false;
                deleteTagCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    deleteTagCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (deleteTagCommandResponse.Success)
            {
                var tag = await _tagRepository.GetByBusinessIdAsync(request.Id);
                if (tag != null)
                {
                    await _tagRepository.DeleteAsync(tag);
                    deleteTagCommandResponse.Success = true;
                }
                else
                {
                    deleteTagCommandResponse.Success = false;
                    deleteTagCommandResponse.ValidationErrors = new List<string>
                    {
                        "Selected tag doesn't exist."
                    };
                }
            }

            return deleteTagCommandResponse;
        }
    }
}
