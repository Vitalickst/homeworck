using System;


namespace InsertionSort_home
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
        static void Main(string[] args)
        {
            int[] array = {-42, -11, 0, 1, 12, 68, 6, 90, -9};
            InsertionSort.Sort(array);
            Console.WriteLine(string.Join(" | ",array));
        }
    }
}
