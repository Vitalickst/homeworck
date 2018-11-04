using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructure
{
    struct MyStructure
    {
        public int i;
        public MyStructure(int i)
        {
            this.i = i;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Different ways of using structures in C#");
            MyStructure myS1 = new MyStructure();
            myS1.i = 1;
            Console.WriteLine("myS1.i={0}", myS1.i);

            //Another way of using structure
            MyStructure myS2 = new MyStructure(10);
            Console.WriteLine("myS2.i={0}", myS2.i);

            //Another way of using structure
            MyStructure myS3;
            myS3.i = 100;
            Console.WriteLine("myS3.i={0}", myS3.i);
            Console.ReadKey();
        }
    }
}
