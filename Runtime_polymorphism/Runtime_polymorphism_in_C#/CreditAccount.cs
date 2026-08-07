using System;
using System.Collections.Generic;
using System.Text;

namespace Runtime_polymorphism_in_C_
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

            Console.WriteLine("Withdraw completed from Credit Account");
        }

        public void ShowCreditLimit()
        {
            Console.WriteLine("Credit Limit: " + CreditLimit);
        }
    }
}
