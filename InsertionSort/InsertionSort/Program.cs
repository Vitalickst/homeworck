using System;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
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
        static void Main()
        {
            int[] array = {-11, 12, -42, 0, 1, 90, 68, 6, -9};
            InsertionSort.Sort(array);
            Console.WriteLine(string.Join(" | ", array));
        }
    }
}
