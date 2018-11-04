using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizeOnStructures
{
    class Program
    {
        struct OutherStruct
        {
            public void Show()
            {
                Console.WriteLine("OutherStruct.Show()");
            }
            internal struct InnerStruct
            {
                public void Show()
                {
                    Console.WriteLine("InnerStruct.Show()");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quiz on structs");
            OutherStruct.InnerStruct obS = new OutherStruct.InnerStruct();
            obS.Show();
            Console.ReadKey();
        }
    }
}
