using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class_and_Abstract_method_in_C_sharp
{
    public class DebitAccount : BankAccount
    {
        public double DailyWithdrawLimit { get; set; }

        public DebitAccount(string accountNo, string customerName, double balance, double dailyWithdrawLimit) : base(accountNo, customerName, balance)
        {
            DailyWithdrawLimit = dailyWithdrawLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount > DailyWithdrawLimit)
            {
                Console.WriteLine("Daily withdrawal limit exceeded");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine("Withdraw successful from Debit Account");
            }
        }
    }
}
