using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    internal class Question18
    {
        static void Main()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("enter number");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
