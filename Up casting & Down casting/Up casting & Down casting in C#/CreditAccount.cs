using System;
using System.Collections.Generic;
using System.Text;

namespace Up_casting___Down_casting_in_C_
{
    public class CreditAccount : BankAccount
    {
        public double CreditLimit { get; set; }

        public void ShowCreditLimit()
        {
            Console.WriteLine("Credit Limit: " + CreditLimit);
        }
    }
}
