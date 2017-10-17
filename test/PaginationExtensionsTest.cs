using System.Collections.Generic;
using Xunit;
using System.Linq;
using Reusables.Pagination;
using FluentAssertions;
using System;

public class PaginationExtensionsTest
{

    [Fact]
    public void ShouldCreatePagination()
    {

        var paginationResult = CreateFoo()
               .OrderBy(x => x)
               .Paginate(new QueryPagination { Page = 1, Size = 4 });

        paginationResult.Count().Should().Equals(4);

        paginationResult.ToArray()[0].Should().Be("001");
        paginationResult.ToArray()[1].Should().Be("002");
        paginationResult.ToArray()[2].Should().Be("003");
        paginationResult.ToArray()[3].Should().Be("004");

    }

    [Fact]
    public void ShouldGenerateErrorWhenNotInformQueryPagination()
    {
        Action act = () => CreateFoo().OrderBy(x => x).Paginate(null);
        act.ShouldThrow<ArgumentNullException>();
    }

    private static IQueryable<string> CreateFoo() => new List<string>
        {
            "001",
            "002",
            "003",
            "004",
            "005",
            "006",
            "007",
            "008",
        }.AsQueryable();

}
