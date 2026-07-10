using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class person
    {
        //public string firstname { get; private set; }

        //public string firstname;
        //public string middlename;
        //public string lastname;

        //public string Firstname
        //{
        //    set
        //    {
        //        if (value.Length >= 2)
        //        {
        //            firstname = value;
        //        }

        //        else
        //        {
        //            Console.WriteLine("Firstname must be at least 2 characters long.");
        //        }
        //    }
        //    get { return firstname; }
        //}

        //public void setfiestname(string firstname)
        //{
        //    if (firstname.Length >= 2)
        //    {
        //        this.firstname = firstname;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Firstname must be at least 2 characters long.");
        //    }
        //    return firstname;
        //}
        public string getfullname()
        {
            string fullname = firstname + " " + middlename + " " + lastname;
            return firstname;
        }
           
    }
}

