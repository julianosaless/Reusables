using System;
using Xunit;
using Reusables.StringExtensions;
using FluentAssertions;

namespace Reusables.Test
{
    public class StringExtensionsTest
    {
        [Fact]
        public void ShouldConverToEnum()
        {
            var currentEnum = "BarType".ToEnum<FooType>();
            currentEnum.GetType().Should().Be(typeof(FooType));
        }

        [Fact]
        public void ShouldVerifyNullOrEmpty()
        {
            "".IsNullOrEmpty().Should().BeTrue();
            "newstring".IsNullOrEmpty().Should().BeFalse();
        }

        [Fact]
        public void ShouldVerifyNullOrWhiteSpace()
        {
            "".IsNullOrWhiteSpace().Should().BeTrue();
            "newstring".IsNullOrWhiteSpace().Should().BeFalse();
        }

        [Fact]
        public void ShouldCreateCamelCase() => "foo name".ToCamelCase().Should().Be("Foo Name");

        public enum FooType
        {
            BarType = 1,
        }
    }
}
