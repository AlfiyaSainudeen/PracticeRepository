namespace HandsOnClassesAndObjects
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //create object of a student
            Student obj = new Student();
            obj.id = 43202;
            obj.name = "alfi";
            obj.gender = 'F';
            obj.age = 10;
            obj.Display();
            Student s1 = new Student();
            s1.id = 43212;
            s1.name = "althaf";
            s1.gender = 'M';
            s1.age = 5;
            s1.Display();
            Student s2 = new Student();
            s1.Display();//return default values of class variables
            Student s3 = new Student()//object initializer
            {
                id = 34234,
                    name = "anzal",
                    age = 11,
                    gender = 'M'
            };
            s3.Display();
            //Student s4 = null;//s4 object instance is null
            //s4.id = 433256;
            //s4.name = "ajin";
            //s4.Display();
            //array of students
            Student[] students = new Student[3];
            students[0]=new Student()
            {
                id = 34235,
                name = "aleena",
                age = 11,
                gender = 'F'
            };
            students[0] = new Student()
            {
                id = 34235,
                name = "joyna",
                age = 11,
                gender = 'F'
            };
            students[0] = new Student()
            {
                id = 34235,
                name = "joseph",
                age = 11,
                gender = 'M'
            };
            Console.WriteLine();
            students[0].Display();
            Console.WriteLine();
            foreach(Student s in students)//using foreach
            {
                s.Display();
            }
            Console.WriteLine();
            for(int i=0;i<3;i++)
            {
                students[i].Display();
            }
        }
    }
}
