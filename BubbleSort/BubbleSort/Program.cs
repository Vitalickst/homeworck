using System;

namespace BubbleSort
{
    public static class BubbleSort
    {
        public static void SortModification<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                }

                if (!isAnyChange)
                {
                    break;
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
            int[] array = { -11, 12, -42, 0, 1, 90, 68, 6, -9};
            BubbleSort.SortModification(array);
            Console.WriteLine(string.Join(" | ",array));
        }
    }
}
