using System;
using System.Collections.Generic;
using System.Text;

namespace Using_constructor_base_and_sub_class
{
    public class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountNo, string customerName)
        {
            AccountNo = accountNo;
            CustomerName = customerName;

            Console.WriteLine("BankAccount constructor called");
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine("Account No: " + AccountNo);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
