using System;
using System.Collections.Generic;
using System.Text;

namespace Explicit_interface_implementation_in_C_Sharp
{
    public class Person : IStudent, ITeacher
    {
        void ITeacher.ShowInformation()
        {
            Console.WriteLine("This is Teacher Information");
        }

        void IStudent.ShowInformation()
        {
            Console.WriteLine("This is Student Information");
        }
    }
}
