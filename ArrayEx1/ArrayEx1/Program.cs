using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo: A simple array example");
            int[] myInts = new int[3];
            myInts[0] = 5;
            myInts[1] = 15;
            myInts[2] = 25;
            Console.WriteLine("Elements of myInts array are as follows:");
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine(myInts[i]);
            }
            Console.ReadKey();
        }
    }
}
