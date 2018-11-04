using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumQuizesPart3
{
    class Program
    {
        enum Values { val1, val2 = 100, val3 = 50, val4, val5 }
        static void Main(string[] args)
        {
            Console.WriteLine("*** Quiz on enum ***");
            foreach (Values v in Enum.GetValues(typeof(Values)))
            {
                Console.WriteLine("{0} is storing {1}", v, (int)v);
            }
            Console.ReadKey();
        }
    }
}
