using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_relationship_in_C_
{
    public class CreditAccount : BankAccount
    {
        public string AccountType { get; set; }

        public string Withdraw(double amount)
        {
            Balance = Balance - amount;
            return "Withdraw successful";
        }
    }
}
