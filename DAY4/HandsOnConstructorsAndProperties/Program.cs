namespace HandsOnConstructorsAndProperties
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string school;
        public static string city;
        //default constructor

        public Student()
        {
        school = "DPS";
        }
        //parameter constructor
        public Student(string fname,string lname,string s)
        {
            firstName = fname;
            lastName = lname;
            school = s;
        }
        public Student(string fname,string lname)
        {
            firstName = fname;
            lastName = lname;
        }
        //static constructor(not included any access specifier and parameters)
        // a class can have only 1 static constructor
        //static constructor is the first members to invoke in a class

        static Student()
        {
            //define only static variable
            city = "kochi";
        }

        public void Display()
        {
            Console.WriteLine($"Name:{firstName} {lastName} School:{school}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student s1 = new Student();
            s1.firstName = "Rahul";
            s1.lastName = "Shetty";
            s1.Display();
            Student s2 = new Student();
            s2.firstName = "Alfiya";
            s2.lastName = "Sainudeen";
            s2.Display();
            Student s3 = new Student("Ajin", "Santhosh", "GHS");
            s3.Display();
            Student s4 = new Student("Anzal", "Shanavas", "vHS");
            s4.Display();
            Student s5 = new Student("Anzal", "Shanavas");
            s5.school = "gth";
            s5.Display();

        }
    }
}
