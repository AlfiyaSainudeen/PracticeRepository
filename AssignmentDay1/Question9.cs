﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    internal class Question9
    {
        static void Main()
        {
            int n1 = 0, n2 = 1, n3 = 0, i, number;
            Console.WriteLine("enter the no of elements");
            number = int.Parse(Console.ReadLine());
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;

            }
        }
    }
}
