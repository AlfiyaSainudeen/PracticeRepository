using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    internal class Question17
    {
        static void Main()
        {
            Console.WriteLine("enter first word");
            string n = Console.ReadLine();
            Console.WriteLine("enter second word");
            string n2 = Console.ReadLine();
            if (n.Equals(n2)) //Equals method return true when strings are equal
            {
                Console.WriteLine("strings are equal");
            }
            else
            {
                Console.WriteLine("strings are not equal");
            }

        }
    }
}
