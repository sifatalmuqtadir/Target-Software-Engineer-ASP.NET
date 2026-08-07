using System;
using System.Collections.Generic;
using System.Text;

namespace Method_overriding_in_C_
{
    public class DebitAccount : BankAccount
    {
        public string AccountType { get; set; }

        public override string withdraw(double amount)
        {
            if(balance >= amount)
            {
                return base.withdraw(amount);
            }
            return "You have do not enough balance";
        }
    }
}
