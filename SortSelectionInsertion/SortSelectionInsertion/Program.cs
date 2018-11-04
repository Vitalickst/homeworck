using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSelectionInsertion
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }

                SwapSort.Swap(array, i, minIndex);
            }
        }
    }

    public static class InsertionSort
    {
        public static void Sotr<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    SwapSort.Swap(array, j, j - 1);
                    j--;
                }
            }
        }
    }

    public static class SwapSort
    {
        public static void Swap<T>(T[] array, int first, int second)
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
            int[] array = {-11, 12, -42, 0, 1, 90, 68, 6, -9, -99};
            //SelectionSort.Sort(array);
            InsertionSort.Sotr(array);
            Console.WriteLine(string.Join(" | ",array));
        }
    }
}
