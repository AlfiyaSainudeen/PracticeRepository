using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    internal class Question8
    {
        static void Main()
        {
            int i, fact = 1, number;
            Console.WriteLine("enter any number");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("factorial of " + number + "is:" + fact);
        }
    }
}
