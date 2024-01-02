using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    internal class Question6
    {
        static void Main(string[] args)
        {
            double celcius;
            Console.WriteLine("enter fahrenhit value");
            double fahrenhit = Convert.ToDouble(Console.ReadLine());
            celcius = (fahrenhit - 32) * 5 / 9;
            Console.WriteLine("the converted into celcius=" + celcius);
            Console.Read();
        }
    }
}
