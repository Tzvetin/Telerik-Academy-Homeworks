// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static double Sum<T>(this IEnumerable<T> collection)
            where T : IConvertible
        {
            CheckColectionPreconditions(collection);
            double sum = 0.0;
            foreach (var item in collection)
            {
                sum += item.ToDouble(new NumberFormatInfo());
            }
            return sum;
        }

        public static double Product<T>(this IEnumerable<T> collection)
            where T : IConvertible
        {
            CheckColectionPreconditions(collection);
            double product = 1.0;
            foreach (var item in collection)
            {
                product *= item.ToDouble(new NumberFormatInfo());
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            CheckColectionPreconditions(collection);
            T min = collection.First<T>();
            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
           where T : IComparable
        {
            CheckColectionPreconditions(collection);
            T max = collection.First<T>();
            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection)
            where T : IConvertible
        {
            CheckColectionPreconditions(collection);
            double average = 0.0;
            int count = 0;
            double sum = 0.0;
            foreach (var item in collection)
            {
                sum += item.ToDouble(new NumberFormatInfo());
                count++;
            }
            average = sum / (double)count;
            return average;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>(0);
            list.Add(5);
            list.Add(4);
            list.Add(-2);
            Console.WriteLine(list.Sum<int>());
            Console.WriteLine(list.Product<int>());
            Console.WriteLine(list.Max<int>());
            Console.WriteLine(list.Min<int>());
            Console.WriteLine(list.Average<int>());
        }

        private static void CheckColectionPreconditions<T>(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new NullReferenceException("Collection is null");
            }
            if (collection.Count<T>() == 0)
            {
                throw new NullReferenceException("Collection is empty");
            }
        }
    }
}
