using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Example_in_C_Sharp
{
    internal class Student
    {
        public string Name { get; set; }

        public static string UniversityName = "AIUB";

        public void ShowStudentInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("University: " + UniversityName);
        }

        public static void ShowUniversity()
        {
            Console.WriteLine("University Name: " + UniversityName);
        }
    }
}
