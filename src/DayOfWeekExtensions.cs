using System;

namespace Reusables.DayOfWeekExtensions
{
    public static class DayOfWeekExtensions
    {
        public static bool IsWeekend(this DayOfWeek date) => date.Equals(DayOfWeek.Saturday) || date.Equals(DayOfWeek.Sunday);
        public static bool IsWeekday(this DayOfWeek date)
        {
            return date.Equals(DayOfWeek.Monday) || date.Equals(DayOfWeek.Tuesday) ||
                   date.Equals(DayOfWeek.Wednesday) || date.Equals(DayOfWeek.Thursday) ||
                   date.Equals(DayOfWeek.Friday);
        }
    }
}