using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_Interface_Implementation_in_C_Sharp
{
    public class Student : IInformation, IResult
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public double CGPA { get; set; }

        public void ShowInformation()
        {
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Student Name: " + StudentName);
        }

        public void ShowResult()
        {
            Console.WriteLine("CGPA: " + CGPA);
        }
    }
}
