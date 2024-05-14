using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Commands.DeleteStyle
{
    public class DeleteStyleCommandHandler(
        IBaseRepository<Style> styleRepository,
        IBaseRelationRepository<RelationArtistStyle> relationRepository,
        DeleteStyleCommandValidator validator) : IRequestHandler<DeleteStyleCommand, BaseResponse>
    {
        private readonly IBaseRepository<Style> _styleRepository = styleRepository;
        private readonly IBaseRelationRepository<RelationArtistStyle> _relationRepository = relationRepository;
        private readonly DeleteStyleCommandValidator _validator = validator;

        public async Task<BaseResponse> Handle(DeleteStyleCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                return new BaseResponse
                {
                    Message = "Validation Error(s)",
                    ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
                };
            }

            var style = await _styleRepository.GetByBusinessIdAsync(request.StyleId);

            if (style == null)
            {
                return new BaseResponse
                {
                    Message = "Style was not found.",
                    ValidationErrors = { $"Style with ID {request.StyleId} was not found." }
                };
            }

            // Delete associated relations
            await _relationRepository.DeleteRelationsByMainEntityIdAsync(style.EntityId, "StyleId");

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
