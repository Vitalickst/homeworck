using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrays = new int[10, 10];

            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                for (int j = 0; j < arrays.GetLength(1); j++)
                {
                    arrays[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                for (int j = 0; j < arrays.GetLength(1); j++)
                {
                    Console.Write("{0,4}",arrays[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
