using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test on Array initialization");
            int[] myIntArray = new int[4];
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine("myIntArray[" + i + "] is : {0}",myIntArray[i]);
            }
            Console.WriteLine();
            string[] myStringArray = new string[4];
            for (int i = 0; i < myIntArray.Length; i++)
            {
                bool value = string.IsNullOrEmpty(myStringArray[i]);
                if (value)
                {
                    Console.WriteLine("myStringArray[" + i + "] is null.");
                }
                else
                {
                    Console.WriteLine("myStringArray[" + i + "] is NOT null.");
                }
            }
            Console.ReadKey();
        }
    }
}
