using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    public class savingAccount : bankAccount
    {
        //public savingAccount(string s)
        //{
        //    Console.WriteLine(value: "Saving account created.");
        //}

        public savingAccount(string accountNumber, string customerName, double interestAmount): base(accountNumber,customerName)
        {
            //this.accountNumber = accountNumber;
            //this.customerName = customerName;
            this.interestAmount = interestAmount;
        }
        public double interestAmount { get; set; }
        public override string withdraw(double amount)
        {
            return base.withdraw(amount);
        }
    }
}
