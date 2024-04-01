using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TaskCategories.Queries.CountTaskCategories
{
    public class CountTaskCategoriesQueryHandler : IRequestHandler<CountTaskCategoriesQuery, CountTaskCategoriesQueryResponse>
    {
        private readonly IBaseRepository<TaskCategory> _taskCategoryRepository;

        public CountTaskCategoriesQueryHandler(IBaseRepository<TaskCategory> taskCategoryRepository)
        {
            _taskCategoryRepository = taskCategoryRepository;
        }

        public async Task<CountTaskCategoriesQueryResponse> Handle(CountTaskCategoriesQuery request, CancellationToken token)
        {
            var taskCategoriesCount = await _taskCategoryRepository.CountAsync();

            return new CountTaskCategoriesQueryResponse
            {
                Success = true,
                Message = $"Total Task Categories : {taskCategoriesCount}",
                TaskCategoriesCount = taskCategoriesCount
            };
        }
    }
}