using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_overloading_in_c_
{
    class Person
    {
        public string Firstname { get; set; }
        public string Middlename {  get; set; }
        public string Lastname { get; set; }

        public Person(string firstName, string middlename, string lastName)
        {
            Firstname = firstName;
            Middlename = middlename;
            Lastname = lastName;
        }

        public Person(string firstName, string lastName)
        {
            Firstname = firstName;
            Lastname = lastName;
        }

        //Default Constructor
        public Person()
        {

        }

        public string GetFullName()
        {
            return Firstname + " " + Middlename+ " " + Lastname;
        }
    }
}
