using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_OOP_Class_and_Object
{
    class Person
    {
        public string firstName;
        public string lastName;

        public string GetFullName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
    }
}
