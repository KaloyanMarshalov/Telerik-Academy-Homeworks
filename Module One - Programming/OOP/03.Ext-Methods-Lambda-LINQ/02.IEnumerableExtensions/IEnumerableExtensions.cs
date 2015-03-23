using System.Collections.Generic;
using System.Linq;
namespace _02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> enumeration)
        {
            T result = default(T);
            foreach (T item in enumeration)
            {
                result += (dynamic)item;
            }

            return result;
        }
        public static T Product<T>(this IEnumerable<T> enumeration)
        {
            T result = (dynamic) 1;

            foreach (T item in enumeration)
            {
                result *= (dynamic)item;
            }
            return result;
        }
        public static T Min<T>(this IEnumerable<T> enumeration)
        {
            T min = enumeration.First();
            foreach (T item in enumeration)
            {
                if (item < (dynamic)min)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> enumeration)
        {
            T max = enumeration.First();
            foreach (T item in enumeration)
            {
                if (item > (dynamic)max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> enumeration)
        {
            return (dynamic)enumeration.Sum() / enumeration.Count();
        }
    }
}
