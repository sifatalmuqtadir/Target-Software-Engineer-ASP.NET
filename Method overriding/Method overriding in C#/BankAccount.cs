using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Method_overriding_in_C_
{
    public class BankAccount
    {
        public string AccountNo { get; set; }
        public string Name { get; set; }
        public double balance { get; set; }

        public string deposit(double amount)
        {
            balance += amount;
            return "Deposited";
        }

        public virtual string withdraw(double amount)
        {
            balance -= amount;
            return "Withdraw Successful";
        }
    }
}
