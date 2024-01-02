using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    internal class Demo5
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();
            //add items
            stack.Push("hai");
            stack.Push("hari");
            stack.Push("hani");
            stack.Push("haai");
            foreach (var item in stack)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine("picked item:" + stack.Peek());
            Console.WriteLine("removed item:" + stack.Pop());
            Console.WriteLine();
            foreach (var item in stack)
                Console.WriteLine(item);
            //clear all items
            stack.Clear();

        }
    }
}
