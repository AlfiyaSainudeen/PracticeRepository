namespace HandsOnInheritance
{
    class A
    {
        //variables
        public int a;
        public int b;
    }
    class B : A
    {
        public int c;
        public void f()
        {
            a = 10;
            b = 20;
            c = 30;
        }
        public void Display()
        {
            Console.WriteLine($"A={a} B={b} C={c}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.f();
            obj.Display();
            B obj1 = new B();
            obj1.a = 25;
            obj1.b = 35;
            obj1.c = 45;
            obj1.Display();
        }
    }
}
