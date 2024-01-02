using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6
{
    internal class Question2
    {
       
            static void Main(string[] args)
            {
                // Write an Arraylist that will hold the names of all students and display them in descending order
                ArrayList list = new ArrayList();
                list.Add("Alfiya");
                list.Add("Ajin");
                list.Add("Anzal");
                list.Add("Joseph");
                list.Add("Tobince");

                list.Sort();
                list.Reverse();
                foreach (var i in list)
                {
                    Console.WriteLine(i);
                }
            }
        
    }
}
