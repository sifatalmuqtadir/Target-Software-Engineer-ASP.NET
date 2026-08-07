using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;

namespace Extensible_dynamic_type_in_C_Sharp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public dynamic ExtraInformation { get; set; }

        public Student()
        {
            ExtraInformation = new ExpandoObject();
        }

        public void ShowBasicInformation()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
        }
    }
}
