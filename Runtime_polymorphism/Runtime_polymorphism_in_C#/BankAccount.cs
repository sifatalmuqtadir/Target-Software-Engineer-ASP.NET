using System;
using System.Collections.Generic;
using System.Text;

namespace Runtime_polymorphism_in_C_
{
    public class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        // Base class constructor
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
            Console.WriteLine("Current Balance: " + Balance);
        }

        // Child classes can override this method
        public virtual void Withdraw(double amount)
        {
            Balance = Balance - amount;

            Console.WriteLine("Withdraw completed from Bank Account");
        }
    }
}
