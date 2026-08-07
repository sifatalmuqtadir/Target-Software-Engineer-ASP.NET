using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    public class checkingAccount : bankAccount
    {
        public checkingAccount()
        {
            Console.WriteLine("Checking account created.");
        }
        public double serviceCharge { get; set; }
    }
}
