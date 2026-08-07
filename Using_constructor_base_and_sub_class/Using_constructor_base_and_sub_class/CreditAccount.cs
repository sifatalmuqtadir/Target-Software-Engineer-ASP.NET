using System;
using System.Collections.Generic;
using System.Text;

namespace Using_constructor_base_and_sub_class
{
    public class CreditAccount : BankAccount
    {
        public double CreditLimit { get; set; }

    public CreditAccount(string accountNo, string customerName, double creditLimit) : base(accountNo, customerName)
        {
            CreditLimit = creditLimit;

            Console.WriteLine("CreditAccount constructor called");
        }

        public void ShowCreditLimit()
        {
            Console.WriteLine("Credit Limit: " + CreditLimit);
        }
    }
}
