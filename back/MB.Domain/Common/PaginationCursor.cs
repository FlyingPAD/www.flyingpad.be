namespace MB.Domain.Common
{
    public class PaginationCursor<T>
    {
        public int TotalItems { get; set; } = 0;
        public int ItemPosition { get; set; } = 0;
        public List<T> Entities { get; set; } = [];
        public Guid? PreviousId { get; set; } = null;
        public Guid? NextId { get; set; } = null;
    }
}
