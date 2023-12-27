using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Student
    {
        //class - members like variables,methods,constructors,proerties,destructors and indexes
        //class-variables
        public int id;
        public string name;
        public byte age;
        public char gender;

        public void Display()//method
        {

            Console.WriteLine($"Id:{id},Name:{name},age:{age},gender:{gender}");
        }
          
    }
}
