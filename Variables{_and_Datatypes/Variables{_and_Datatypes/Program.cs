using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables__and_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Variables and Datatypes *******");

            Console.WriteLine("");

            string student_id = "Student1068446";
            string student_name = "Muhammad Ali";
            int student_age = 25;
            int student_class = 10;

            Console.WriteLine("Student Id : "+student_id);
            Console.WriteLine("Student Name : "+student_name);
            Console.WriteLine("Student Age : "+student_age);
            Console.WriteLine("Student Class : "+student_class);

            Console.ReadKey();
        }
    }
}
