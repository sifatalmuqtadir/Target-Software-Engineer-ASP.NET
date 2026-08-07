using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class_and_Abstract_method_in_C_sharp
{
    public class CreditAccount : BankAccount
    {
        public double CreditLimit { get; set; }

        public CreditAccount(string accountNo, string customerName, double balance, double creditLimit) : base(accountNo, customerName, balance)
        {
            CreditLimit = creditLimit;
        }

        public override void Withdraw(double amount)
        {
            Balance = Balance - amount;

            Console.WriteLine("Withdraw successful from Credit Account");
        }
    }
}
