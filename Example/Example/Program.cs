using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(13));
            Console.ReadKey();
        }

        public static int sum(int num)
        {
            if (num != 0)
            {
                return (num % 10 + sum(num / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}
