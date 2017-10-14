using System;
using System.Globalization;

namespace Reusables.StringExtensions
{
    public static class StringExtensions
    {
        public static T ToEnum<T>(this string str) => (T)Enum.Parse(typeof(T), str);
        public static bool IsNullOrEmpty(this string str) => String.IsNullOrEmpty(str);
        public static bool IsNullOrWhiteSpace(this string str) => String.IsNullOrWhiteSpace(str);
        public static string ToCamelCase(this string str) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
    }
}
