using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumQuizes
{
    class Program
    {
        const int MYCONST = 50;
        enum Values { val1, val2 = MYCONST, val3, val4=21, val5}
        static void Main(string[] args)
        {
            Console.WriteLine("*** Quiz on enum ***");
            int x1 = (int)Values.val1;
            int x2 = (int)Values.val2;
            int x3 = (int)Values.val3;
            int x4 = (int)Values.val4;
            int x5 = (int)Values.val5;
            Console.WriteLine("x1={0}", x1);
            Console.WriteLine("x2={0}", x2);
            Console.WriteLine("x3={0}", x3);
            Console.WriteLine("x4={0}", x4);
            Console.WriteLine("x5={0}", x5);
        }
    }
}
