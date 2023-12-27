using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo3
    {
       // public int Sum(int[]a)//here declare array as parameter
      //  {
        //    int result = 0;
          //  foreach(int k in a)
          //  {
             //   result += k;
           // }
          //  return result;

       // }
        public int Sum(params int[] a)//params keyword allow to pass multiple parameter values at runtime
        {
            int result = 0;
            foreach (int k in a)
            {
                result += k;
            }
            return result;

        }

        public string[] Flowers() //return string array
        {
            string[] flowers = { "rose", "lilly", "jasmine", "tulips" };
            return flowers;
        }
        static void Main()
        {
            Demo3 demo= new Demo3();
            int r = demo.Sum(new int[] { 23, 34, 45, 56 });
            Console.WriteLine(r);
            int[] n= { 23, 34, 45, 96 };
            r = demo.Sum(n);
            Console.WriteLine(r);
            string[] result = demo.Flowers();
            foreach (string s in result)
                Console.WriteLine(s);
            r = demo.Sum(34, 45, 56, 67, 67, 67);
            r = demo.Sum(34, 432, 23);
            r = demo.Sum(12, 23);
            

        }
    }
}
