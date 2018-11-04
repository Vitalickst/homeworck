using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Multidimensional array demo ***");
            Console.WriteLine("Enter how many rows you want ?");
            string rowSize = Console.ReadLine();
            int row = int.Parse(rowSize);
            Console.WriteLine("Enter how many columns you want ?");
            string columnSize = Console.ReadLine();
            int column = int.Parse(columnSize);
            int[,] myArray = new int[row, column];
            Console.WriteLine("Enter Data");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Printing the matrix
            Console.WriteLine("Your matrix is as below:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(myArray[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
