using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Staff
    {
        //instance variables (access by class object)
        public int staffId;
        public string staffName;
        //static vbariable(access by class name and change at runtime)
        public static string school;
        public static string branch;
        //const variables(access by classname and can't be change at runtime)
        public const string city = "Hyderabad";
        public string Display()
        {
            return $"Id:{staffId} Name:{staffName} School:{school} Branch:{branch} city:{city}";
        }

        static void Main()
        {
            //access static data
            Staff.school = "DPS";
            Staff.branch = "JublisHills";
            Staff s1 = new Staff() { staffId = 43832, staffName = "jessy" };
            Staff s2 = new Staff() { staffId = 43833, staffName = "mani" };
            Staff s3 = new Staff() { staffId = 43834, staffName = "sujen" };
            Console.WriteLine(s1.Display());
            Console.WriteLine(s2.Display());
            Console.WriteLine(s3.Display());
            Staff.branch = "HitechCity";
            Staff s4 = new Staff() { staffId = 43835, staffName = "jeetan" };
            Staff s5 = new Staff() { staffId = 43836, staffName = "hani" };
            Console.WriteLine(s4.Display());
            Console.WriteLine(s5.Display());
        }
    }
}
