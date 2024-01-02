using System.Collections;

namespace HandsOnNonGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a variables with var keyword can accept any type of data while initilize data
            //var variable we can use only in local scope
            var a = 10;
            var b = "David";
            var c = 'c';
            ArrayList obj = new ArrayList();
            //add items
            obj.Add(12);
            obj.Add("David");
            obj.Add('a');
            obj.Add(true);
            obj.Insert(2, 12.34);//2 is thw index value of the array 12.34 isthe value
            Console.WriteLine("sice:" + obj.Count);
            //access a value
            char ch = (char)obj[3];//arraylist returns data in object from so it required unboxing every time to assign the data to paraticular variable
            int n = (int)obj[0];
            //remove a value
            obj.Remove("David");
            Console.WriteLine("size:" + obj.Count);
            //return all items
            foreach (object k in obj)
                Console.WriteLine(k);
            Console.WriteLine();
            foreach (var k in obj)
                Console.WriteLine(k);

        }
    }
}
