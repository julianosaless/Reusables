using System;
using Xunit;
using FluentAssertions;
using Reusables.DayOfWeekExtensions;
using System.Globalization;

namespace Reusables.Test
{
    public class DayOfWeekExtensionsTests
    {
        [Fact]
        public void ShouldVerifyIsWeekend()
        {
            Convert.ToDateTime("13/10/2017", new CultureInfo("pt-br"))
                    .DayOfWeek
                    .IsWeekend().Should().BeFalse();


            Convert.ToDateTime("14/10/2017", new CultureInfo("pt-br"))
            .DayOfWeek
            .IsWeekend().Should().BeTrue();
        }


        [Fact]
        public void ShouldVerifyIsWeekday()
        {
            Convert.ToDateTime("13/10/2017", new CultureInfo("pt-br"))
                    .DayOfWeek
                    .IsWeekday().Should().BeTrue();


            Convert.ToDateTime("14/10/2017", new CultureInfo("pt-br"))
                    .DayOfWeek
                    .IsWeekday().Should().BeFalse();
        }
    }
}
