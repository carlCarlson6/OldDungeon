using System.Collections.Generic;
using System.Linq;

namespace Core.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<int> Range(int number) => Enumerable.Range(1, number is 0 ? 1 : number);

        public static T Second<T>(this IEnumerable<T> enumerable) => enumerable.ToList()[1];

        public static T? SecondOrDefault<T>(this IEnumerable<T> enumerable)
        {
            try
            {
                return enumerable.ToList()[1];
            }
            catch
            {
                return default;
            }
        }
    }
}