using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_home
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] testPalindrome = word.ToCharArray();
            int len = testPalindrome.Length;
            int mid = len / 2;
            bool palindrome = true;
            //odd palindrome
            if (len % 2 != 0)
            {
                int j = mid + 1;
                for (int i = mid - 1; i >= 0; i--)
                {
                    if (testPalindrome[i] != testPalindrome[j])
                    {
                        palindrome = false;
                        break;
                    }
                    j++;
                }
                Console.WriteLine("The string {0} is palindrome ? {1} ", word, palindrome);
            }
            //even palindrome
            else
            {
                int j = mid;
                for (int i = mid - 1; i >= 0; i--)
                {
                     if (testPalindrome[i] != testPalindrome[j])
                    {
                        palindrome = false;
                        break;
                    }
                    j++;
                }
                Console.WriteLine("The string {0} is palindrome ? {1} ", word, palindrome);
            }
        }
    }
}
