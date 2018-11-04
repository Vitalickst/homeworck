using System;


namespace SelectionInsertionBubbleSort
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
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }

                SwapClass.Swap(array, i, minIndex);
            }
        }
    }

    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j-1]) < 0)
                {
                    SwapClass.Swap(array, j, j - 1);
                    j--;
                }
            }
        }
    }

    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        SwapClass.Swap(array, j, j + 1);
                        isAnyChange = true;
                    }
                }

                if (!isAnyChange)
                {
                    break;
                }

            }
        }
    }

    static class SwapClass
    {
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }

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
            // or: T pivot = array[(lower + upper) / 2];
            do
            {
                while (array[i].CompareTo(pivot) < 0) { j++; }
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
            Console.WriteLine(string.Join(" | ",array));
        }
    }
}
