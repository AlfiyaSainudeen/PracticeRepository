using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6
{
    class Student
    {
        public int id;
        public string name;
        public int age;
        public int std;
        public char section;

    }
    internal class Question5
    {
        static void Main(string[] args)
        {
            /* Create a class with name student and store all the student details in an ArrayList and Display the
             Details.*/
            Student s = new Student() { id = 101, name = "Alfiya", age = 20, std = 10, section = 'A' };
            Student s1 = new Student() { id = 102, name = "Angela", age = 21, std = 9, section = 'B' };
            Student s2 = new Student() { id = 103, name = "Shiji", age = 22, std = 8, section = 'C' };
            ArrayList al = new ArrayList();
            al.Add(s);
            al.Add(s1);
            al.Add(s2);
            foreach (Student i in al)
            {
                Console.WriteLine($"Id:{i.id} Name:{i.name} Age:{i.age} Std:{i.std} Section:{i.section}");
            }
        }
    }
   
}
