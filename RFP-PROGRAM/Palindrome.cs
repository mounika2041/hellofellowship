using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_PROGRAM
{
    class Palindrome
    {
        public static void FindPalindrome(int inputNumb, int reverse)
        {
            if (reverse == inputNumb)
            {
                Console.WriteLine("given number is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
