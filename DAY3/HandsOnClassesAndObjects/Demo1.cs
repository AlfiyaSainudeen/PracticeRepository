using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo1
    {
        private int a;
        public void Message()
        {
            Console.WriteLine("helloworld!!");
            Console.WriteLine("A= " + a);
        }
        public void Seta()
        {
            a = 10;
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello" + name);

        }
        public void add(int a,int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("Addition: " + c);
        }
    }
    class Test_Demo1
    {
        static void Main()
        {
            Demo1 d1 = new Demo1();
            d1.Message();
            d1.Seta();
            d1.Message();
            d1.Greet("sachin");
            d1.Greet("virat");
            d1.add(45, 56);
        }
    }
}
