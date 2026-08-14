using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //bankAccount b1 = new bankAccount();
            //Console.WriteLine();
            savingAccount sv1 = new savingAccount(accountNumber: "1212", customerName: "kamrul", interestAmount: 1200);
            sv1.deposit(amount: 1000);
            
            //sv1.interestAmount = 500;
            //sv1.accountNumber = "SV-001";
            //sv1.customerName = "Sifat Al Muqtadir";
            //sv1.deposit(amount: 1000);
            //sv1.withdraw(amount: 500);
            //double balance = sv1.balance;
            //Console.WriteLine();


            checkingAccount chk1 = new checkingAccount("8080", "Alifa", 9000);
            chk1.deposit(amount: 2000);
            DateTime date = DateTime.Now;
            sv1.transfer("", "", 322, date);
            chk1.transfer("", 550);
            //chk1.serviceCharge = 1000;
            //chk1.accountNumber = "CHK-001";
            //chk1.customerName = "Sifat Al Muqtadir";
            //chk1.deposit(amount: 2000);
            //chk1.withdraw(amount: 300);

            //balance = chk1.balance;

            //// Up Down casting 
            ////bankAccount b1 = new bankAccount();
            //bankAccount b1 =  sv1;

            //savingAccount sv2 = (savingAccount) b1;
            //double interestAmount = sv2.interestAmount;

            //bankAccount b2 = new savingAccount();
            bankAccount b3 = new bankAccount();
            b3.accountNumber = "1234";
            b3.customerName = "Sifat Al Muqtadir";
            b3.deposit(amount: 1000);

            List<bankAccount> accounts = new List<bankAccount>();
            accounts.Add(b3);
            accounts.Add(sv1);
            accounts.Add(chk1);

            foreach (bankAccount bankAccount in accounts)
            {
                bankAccount.withdraw(amount: 1000);
                Console.WriteLine("Withdrawal completed for all accounts.");
            }

            //bankAccount b3 = new checkingAccount();

            ////bankAccount b1 = new bankAccount();
            ////1234

        }
    }
}
