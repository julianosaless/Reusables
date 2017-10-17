using System;
using System.Linq;

namespace Reusables.Pagination
{
    public static class QueryPaginationExtensions
    {
        public static IQueryable<T> Paginate<T>(
              this IQueryable<T> source,
              IQueryPagination pagination)
        {
            if (pagination == null)
                throw new ArgumentNullException(nameof(pagination));

            return source
                .Skip(((pagination.Page == 0 ? 1 : pagination.Page) - 1) * pagination.Size)
                .Take(pagination.Size);
        }
    }
}