using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Commands.UpdateStyle
{
    public class UpdateStyleCommandHandler : IRequestHandler<UpdateStyleCommand, BaseResponse>
    {
        private readonly UpdateStyleCommandValidator _validator;
        private readonly IBaseRepository<Style> _styleRepository;

        public UpdateStyleCommandHandler(UpdateStyleCommandValidator validator, IBaseRepository<Style> styleRepository)
        {
            _styleRepository = styleRepository;
            _validator = validator;
        }

        public async Task<BaseResponse> Handle(UpdateStyleCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Validation failed. Please correct the following errors :",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            var style = await _styleRepository.GetByBusinessIdAsync(request.BusinessId);

            if (style == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Style not found. Please ensure you are using a valid identifier.",
                    ValidationErrors = { $"Style with ID {request.BusinessId} was not found." }
                };
            }

            style.Name = request.Name;

            await _styleRepository.UpdateAsync(style);

            return new BaseResponse
            {
                Success = true,
                Message = "Style updated successfully."
            };
        }
    }
}