using System.Collections.Generic;
using System.Linq;

namespace Core.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<int> Range(int number) => Enumerable.Range(1, number);
    }
}