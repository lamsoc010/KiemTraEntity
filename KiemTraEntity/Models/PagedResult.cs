namespace KiemTraEntity.Models
{
    public class PagedResult<TEntity>
    {
        public List<TEntity> Items { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int PageCount { get; set; }
    }
}
