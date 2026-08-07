using System;
using System.Collections.Generic;
using System.Text;

namespace Up_casting___Down_casting_in_C_
{
    public class DebitAccount : BankAccount
    {
        public double DailyWithdrawLimit { get; set; }

        public void ShowDailyWithdrawLimit()
        {
            Console.WriteLine("Daily Withdraw Limit: " + DailyWithdrawLimit);
        }
    }
}
