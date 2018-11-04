using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSortStart
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);
        }

        private static T[] Sort<T>(T[] array, int lower, int upper)
            where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
            return array;
        }

        private static int Partition<T>(T[] array, int lower, int upper)
            where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];
            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                if (i >= j) { break; }
                Swap(array, i, j);
            }
            while (i <= j);
            return j;
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            QuickSort.Sort(array);
            //var newArray = Qsort.shortQuickSort(array);
            Console.WriteLine(string.Join(" | ", array));
        }
    }

    static public class Qsort
    {
        //(тоже самое, но записанное в одну строку, без объявления переменных)

        public static IEnumerable<T> shortQuickSort<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
            return !list.Any() ? Enumerable.Empty<T>() : list.Skip(1).Where(
                item => item.CompareTo(list.First()) <= 0).shortQuickSort().Concat(new[] { list.First() })
                    .Concat(list.Skip(1).Where(item => item.CompareTo(list.First()) > 0).shortQuickSort());
        }
    }
}
