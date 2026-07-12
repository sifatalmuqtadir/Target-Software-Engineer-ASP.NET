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
            savingAccount sv1 = new savingAccount();
            sv1.interestAmount = 500;
            sv1.accountNumber = "SV-001";
            sv1.customerName = "Sifat Al Muqtadir";
            sv1.deposit(amount: 1000);
            sv1.withdraw(amount: 500);
            double balance = sv1.balance;


            checkingAccount chk1 = new checkingAccount();
            chk1.serviceCharge = 1000;
            chk1.accountNumber = "CHK-001";
            chk1.customerName = "Sifat Al Muqtadir";
            chk1.deposit(amount: 2000);
            chk1.withdraw(amount: 300);

            balance = chk1.balance;

            // Up Down casting 
            //bankAccount b1 = new bankAccount();
            bankAccount b1 =  sv1;

            savingAccount sv2 = (savingAccount) b1;
            double interestAmount = sv2.interestAmount;

            bankAccount b2 = new savingAccount();
            
            bankAccount b3 = new checkingAccount();

            //bankAccount b1 = new bankAccount();
            
        }
    }
}
