using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo2
    {
        public string Greet(string name)
        {
            return "hello" + name;
        }
        public double Square(double a)
        {
            double r = a * a;
            return r;
        }
        public bool IsEven(int no)
        {
            return no % 2 == 0 ? true : false;

        }
        public int Add(int a, int b = 10)//passing default value to the parameter
        {
            return a + b;
        }


        static void Main()
        {
            Demo2 demo = new Demo2();
            string result = demo.Greet("virat");
            Console.WriteLine(result);
            Console.WriteLine(demo.Greet("sachin"));
            Console.WriteLine(demo.Square(25));
            Console.WriteLine(demo.IsEven(23) ? "even" : "odd");
            Console.WriteLine(demo.Add(23, 24));
            Console.WriteLine(demo.Add(23));
            Console.WriteLine(demo.Add(b: 23, a: 24));
        }
    }
}
