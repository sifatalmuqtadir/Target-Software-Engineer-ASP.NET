using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class_and_Abstract_method_in_C_sharp
{
    public abstract class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance {  get; set; }

        public BankAccount(string accountNo, string customerName, double balance)
        {
            AccountNo = accountNo;
            CustomerName = customerName;
            Balance = balance;
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine("Account No: " + AccountNo);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Balance: " + Balance);
        }

        public abstract void Withdraw(double amount);
    }
}
