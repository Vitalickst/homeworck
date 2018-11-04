using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOnArray_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Quiz on Attays ***");
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[6] { 5, 6, 7, 8, 9, 10 };
            jaggedArray[2] = new int[2] { 11, 12 };
            Console.WriteLine(jaggedArray[0].GetUpperBound(0));//3
            Console.WriteLine(jaggedArray[1].GetUpperBound(0));//5
            Console.WriteLine(jaggedArray[2].GetUpperBound(0));//1
            Console.WriteLine(jaggedArray.Length);
            Console.ReadKey();
        }
    }
}
