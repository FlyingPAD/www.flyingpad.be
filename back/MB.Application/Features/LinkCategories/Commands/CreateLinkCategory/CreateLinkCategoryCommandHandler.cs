using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;

public class CreateLinkCategoryCommandHandler : IRequestHandler<CreateLinkCategoryCommand, CreateLinkCategoryCommandResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository;
    private readonly IMapper _mapper;

    public CreateLinkCategoryCommandHandler(IMapper mapper, IBaseRepository<LinkCategory> linkCategoryRepository)
    {
        _mapper = mapper;
        _linkCategoryRepository = linkCategoryRepository;
    }

    public async Task<CreateLinkCategoryCommandResponse> Handle(CreateLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var createLinkCategoryCommandResponse = new CreateLinkCategoryCommandResponse();

        var validator = new CreateLinkCategoryCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            createLinkCategoryCommandResponse.Success = false;
            createLinkCategoryCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                createLinkCategoryCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (createLinkCategoryCommandResponse.Success)
        {
            var linkCategory = new LinkCategory() { Name = request.Name };
            linkCategory = await _linkCategoryRepository.CreateAsync(linkCategory);
            createLinkCategoryCommandResponse.LinkCategory = _mapper.Map<CreateLinkCategoryDto>(linkCategory);
        }

        return createLinkCategoryCommandResponse;
    }
}
