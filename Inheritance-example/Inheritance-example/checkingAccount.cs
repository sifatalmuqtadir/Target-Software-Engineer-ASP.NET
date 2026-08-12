using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    public class checkingAccount : bankAccount
    {
        //public checkingAccount() : base(s: "fsfsfs")
        //{
        //    Console.WriteLine("Checking account created.");
        //}
        public checkingAccount(string accountNumber, string customerName, double serviceCharge): base(accountNumber, customerName)
        {
            //this.accountNumber = accountNumber;
            //this.customerName = customerName;
            this.serviceCharge = serviceCharge;
        }
    }
}
