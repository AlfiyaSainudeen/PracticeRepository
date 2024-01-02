using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNonGenericCollections
{
    internal class Demo1
    {
        static void Main()
        {
            Hashtable obj = new Hashtable();
            //SortedList obj = new SortedList();
            //add key-valur pairs to hashtable
            obj.Add(56788, "Rohan");
            obj.Add(12345, "Jemes");
            obj.Add(34521, "Jemes");
            obj.Add(90988, "Jemes");
            //obj.Add90988,"Anny");exception when key is duplicate
            //access a key-value
            string name = obj[12345].ToString();
            //remove key-pair
            obj.Remove(90988);
            //access all key-value pairs
            foreach (int k in obj.Keys)
            {
                Console.WriteLine($"ID:{k} Name:{obj[k]}");
            }
        }
    }
}
