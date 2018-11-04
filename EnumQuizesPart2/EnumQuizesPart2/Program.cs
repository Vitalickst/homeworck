using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumQuizesPart2
{
    class Program
    {
        enum Values { val1, val2 = 26, val3 = 12, val4, val5 }
        enum TrafficLigt : byte
        { 
            red, green = (int)Values.val3, yellow
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("* Quiz on enum *");
            Console.WriteLine("Default Storage type of Values is {0}", Enum.GetUnderlyingType(typeof(Values)));
            Console.WriteLine("Default Storage type of TrafficLigt is {0}", Enum.GetUnderlyingType(typeof(TrafficLigt)));
        }
    }
}
