using System;
using System.Collections.Generic;
using System.Text;

namespace Up_casting___Down_casting_in_C_
{
    public class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }

        public void ShowAccountInfo()
        {
            Console.WriteLine("Account No: " + AccountNo);
            Console.WriteLine("Customer Name: " + CustomerName);
        }
    }
}
