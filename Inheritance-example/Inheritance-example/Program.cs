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

            bankAccount b1 = new bankAccount();
            
        }
    }
}
