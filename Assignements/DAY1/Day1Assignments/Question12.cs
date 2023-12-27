using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    internal class Question12
    {
        static void Main()
        {
            Console.WriteLine("enter three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a <= b && a <= c)
            {
                Console.WriteLine(a + " is the smallest");
            }

            else if (b <= a && b <= c)
            {
                Console.WriteLine(b + " is the smallest");
            }
            else
            {

                Console.WriteLine(c + " is the smallest");
            }
        }
    }
}
