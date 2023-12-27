using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    internal class Question11
    {
        static void Main()
        {
            int a = 200;
            int b = 300;
            for (int i = a; i < b; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
