namespace Reusables.Pagination
{
    public interface IQueryPagination
    {
        int Page { get; }
        int Size { get; }
    }
}