using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    internal class Question16
    {
        static void Main()
        {
            string str = "", reverse = "";
            int length = 0;
            Console.WriteLine("enter a word");
            str = Console.ReadLine();
            length = str.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            Console.WriteLine("reverse word is {0}", reverse);
            Console.Read();
        }
    }
}
