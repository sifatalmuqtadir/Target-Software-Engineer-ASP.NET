using System;
using System.Collections.Generic;
using System.Text;

namespace Using_constructor_base_and_sub_class
{
    public class DebitAccount : BankAccount
    {
        public double DailyWithdrawLimit { get; set; }

        public DebitAccount(string accountNo, string customerName, double dailyWithdrawLimit) : base(accountNo, customerName)
        {
            DailyWithdrawLimit = dailyWithdrawLimit;

            Console.WriteLine("DebitAccount constructor called");
        }

        public void ShowDailyWithdrawLimit()
        {
            Console.WriteLine("Daily Withdraw Limit: " + DailyWithdrawLimit);
        }
    }
}
