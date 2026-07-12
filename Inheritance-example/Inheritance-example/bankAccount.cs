using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    public class bankAccount
    {
        public string accountNumber { get; set; }
        public string customerName { get; set; }
        public double balance { get; private set; }

        public double serviceCharge { get; set; }
        //public double interestAmount { get; set; }
        public string deposit(double amount)
        {
            balance += amount;
            return $"Deposited {amount}. New balance is {balance}.";

        }

        public string withdraw(double amount )
        {
            balance -= amount;
            return "Withdraw";
        }
    }
}
