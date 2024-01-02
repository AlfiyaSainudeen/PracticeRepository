using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    internal class Demo2
    {
        static void Main()
        {
            List<int> list = new List<int>();
            //add value
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            //access a value
            int k = list[2];//30
            Console.WriteLine("Count" + list.Count);
            list.Remove(10);
            list.Sort();
            list.Reverse();
            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
