using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_relationship_in_C_
{
    public class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }
    }
}
