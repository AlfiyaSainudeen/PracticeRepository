using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{ 
    class Student
    {
        public Student(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Demo3
    {
        static void Main()
        {
            List<string> list = new List<string>() { "rose", "lilly", "jasmine", "tulips" };
            List<bool> list1 = new List<bool>() { true, false, true, false, true };
            List<Student> students = new List<Student>()
            {
                new Student(3245,"alfiya"),
            new Student(4567,"Ajin"),
            new Student(1234,"Anzal"),
            new Student(9876,"Joseph"),
            new Student(4568,"Tobine")
            };
            students.Add(new Student(2345, "Vishnu"));
            Student s = students[4]; ;
            foreach (var item in list1)
            {
                
            }
        }
    }
}
