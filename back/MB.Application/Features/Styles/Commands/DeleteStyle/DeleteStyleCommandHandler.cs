using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Styles.Commands.DeleteStyle;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask
{
    public class DeleteStyleCommandHandler : IRequestHandler<DeleteStyleCommand, BaseResponse>
    {
        private readonly IBaseRepository<Style> _styleRepository;
        private readonly IRelationRepository _relationRepository;
        private readonly DeleteStyleCommandValidator _validator;

        public DeleteStyleCommandHandler(IBaseRepository<Style> styleRepository, IRelationRepository relationRepository, DeleteStyleCommandValidator validator)
        {
            _styleRepository = styleRepository;
            _relationRepository = relationRepository;
            _validator = validator;
        }

        public async Task<BaseResponse> Handle(DeleteStyleCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                return new BaseResponse
                {
                    Message = "Error(s)...",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            var style = await _styleRepository.GetByBusinessIdAsync(request.StyleId);

            if (style == null)
            {
                return new BaseResponse
                {
                    Message = "Error(s)...",
                    ValidationErrors = { $"Style with ID {request.StyleId} was not found." }
                };
            }

            // Delete associated relations

            await _relationRepository.DeleteRelationsByStyleIdAsync(style.EntityId);

            // Delete Style

            await _styleRepository.DeleteAsync(style);

            return new BaseResponse
            {
                Success = true,
                Message = $"Style with ID {request.StyleId} has been successfully deleted."
            };
        }
    }
}