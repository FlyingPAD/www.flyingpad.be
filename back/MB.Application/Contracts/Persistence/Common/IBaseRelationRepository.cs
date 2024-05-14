namespace MB.Application.Contracts.Persistence.Common
{
    public interface IBaseRelationRepository<T> : IBaseRepository<T> where T : class
    {
        Task InsertRelationsAsync(int mainEntityId, List<int> relatedEntityIds, string mainEntityIdProperty, string relatedEntityIdProperty);
        Task DeleteRelationsByMainEntityIdAsync(int mainEntityId, string mainEntityIdProperty);
        Task<int> CountRelationsByMainEntityIdAsync(int mainEntityId, string mainEntityIdProperty);
    }
}
