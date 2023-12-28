using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties
{
    internal class Teacher
    {
        private int teacherId;
        private string teacherName;
        private int age;
        public string NAME
        {
            get { return teacherName; }
            set
            {
                if (value != null)
                    teacherName = value;
                else
                    Console.WriteLine("Name should not be null or empty");

            }
        }
        public int ID
        {
            get { return teacherId; }
            set
            {
                if (value > 0)
                    teacherId = value;
                else
                    Console.WriteLine("invalid id");
            }
        }
        public int AGE
        {
            get { return age; }
            set
            {
                if (value > 24 && value < 28)
                    age = value;
                else
                    Console.WriteLine("your not eligible");

            }
        }
    }
    class Test_Teacher
    {
        static void Main()
        {
            Teacher obj = new Teacher();
            obj.ID = -1;
            obj.AGE = 34;
            obj.NAME = null;
            Console.WriteLine($"ID:{obj.ID} NAME:{obj.NAME} AGE:{obj.AGE}");
            Teacher obj1 = new Teacher();
            obj1.ID = 101;
            obj1.AGE = 25;
            obj1.NAME = "ALFIYA SAINUDEEN";
            Console.WriteLine($"ID:{obj1.ID} NAME:{obj1.NAME} AGE:{obj1.AGE}");
        }
    }
}
