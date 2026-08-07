using System;
using System.Collections.Generic;
using System.Text;

namespace Value_Type___Reference_Type_Sample_Code
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
