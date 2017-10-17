namespace Reusables.Pagination
{
    public sealed class QueryPagination : IQueryPagination
    {
        public QueryPagination()
        {
        }

        public int Page { get; set; } = 1;
        public int Size { get; set; } = 20;
    }
}