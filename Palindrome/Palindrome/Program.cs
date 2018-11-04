using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string test = Console.ReadLine();
            char[] testForPalidrome = test.ToCharArray();
            int len = testForPalidrome.Length;
            int mid = len / 2;
            bool flag = true;
            //odd palindrome
            if (len % 2 != 0)
            {
                int j = mid + 1;
                for (int i = mid - 1; i >= 0; i--)
                {
                    if (testForPalidrome[i] != testForPalidrome[j])
                    {
                        flag = false;
                        break;
                    }
                    j++;
                }
                Console.WriteLine("The string {0} is palidrome? {1}", test, flag);
            }
            //even palindrome
            else
            {
                int j = mid;
                for (int i = mid - 1; i >= 0; i--)
                {
                    if (testForPalidrome[i] != testForPalidrome[j])
                    {
                        flag = false;
                        break;
                    }
                    j++;
                }
                Console.WriteLine("The string {0} is palidrome? {1}", test, flag);
            }
        }
    }
}
