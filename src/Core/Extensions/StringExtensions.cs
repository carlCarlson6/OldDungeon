using System;

namespace Core.Extensions
{
    public static class StringExtensions
    {
        public static int ToInt32(this string? target) => Convert.ToInt32(target);
    }
}