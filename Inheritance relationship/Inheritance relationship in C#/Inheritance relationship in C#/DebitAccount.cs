using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_relationship_in_C_
{
    internal class DebitAccount : BankAccount
    {
        public string AccountType { get; set; }

        public string Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                return "Withdraw successful";
            }
            else
            {
                return "Insufficient balance";
            }
        }
    }
}
