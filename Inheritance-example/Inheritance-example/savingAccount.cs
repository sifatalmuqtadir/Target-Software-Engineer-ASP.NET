using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    public abstract class savingAccount : bankAccount
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
        public override void transfer(string form, string to, double amount)
        {
            base.transfer(form, to, amount);
        }
        //public void transfer(string form, string to, double amount, DateTime date)
        //{
        //    Console.WriteLine($"Transfered {amount} from {form} to {to} date {date} ");
        //}
    }
}
