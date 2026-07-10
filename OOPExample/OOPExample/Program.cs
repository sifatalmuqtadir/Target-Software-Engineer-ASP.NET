using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = 10;
            //int secondNumber = firstNumber;
            //firstNumber = 20;
            //Console.WriteLine(secondNumber);

            //string firstname = Console.ReadLine();
            //person person = new person();
            //if(firstname >= 2)
            //{ 
            //    person.firstname = firstname;
            //}

            //    public person(string firstname, string middlename, string lastname)
            //{
            //    this.firstname = firstname;
            //    this.middlename = middlename;
            //    this.lastname = lastname;
            //}

            //public person2(string firstname, string middlename)
            //{
            //    this.firstname = firstname;
            //    this.middlename = middlename;
            //}


            //new person();
            //person person2 = new person();


            //person.firstname = "john";
            //person.middlename = "f.";
            //person.lastname = "kennedy";

            //string fullname = person.getfullname();
            //console.writeline(fullname);
            //console.readkey();


            //person2.firstname = "j";
            //person2.middlename = "f.";
            //person2.lastname = "brus";

            //public string Code() { 

            Course course = new Course();
            Console.WriteLine("Result: " + course.GetResult());


        }
    }
}
