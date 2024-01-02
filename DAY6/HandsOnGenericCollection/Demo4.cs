using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    internal class Demo4
    {
        static void Main()
        {
            //Dictionary<int,string> obj=new Dictionary<int,string>();
            SortedDictionary<int, string> obj = new SortedDictionary<int, string>();
            obj.Add(1234, "Althaf");
            obj.Add(1235, "Alfiya");
            obj.Add(1236, "Asif");
            obj.Add(1237, "Anzar");
            string name = obj[1234];
            Console.WriteLine(name);
            //obj.Remove(1236);
            foreach(var key in obj.Keys)
            {
                Console.WriteLine($"Id:{key} Name:{obj[key]}");
            }
            Teacher t1 = new Teacher()
            {
                Id = 343,
                Name = "Ameer",
                Email = "ameer@gmail.com",
                Mobile = "1234567890",
                School = "asd"
            };
            Teacher t2 = new Teacher()
            {
                Id = 343,
                Name = "Ameer",
                Email = "ameer@gmail.com",
                Mobile = "1234567890",
                School = "asd"
            };
            Teacher t3 = new Teacher()
            {
                Id = 343,
                Name = "Ameer",
                Email = "ameer@gmail.com",
                Mobile = "1234567890",
                School = "asd"
            };
            Dictionary<int, Teacher> ob1 = new Dictionary<int, Teacher>();
            ob1.Add(t1.Id, t1);
            ob1.Add(t2.Id, t2);
            ob1.Add(t3.Id, t3);
            Teacher t = ob1[t1.Id];
            Console.WriteLine($"Name:{t.Name} Email:{t.Email}");
        }
    }
}
