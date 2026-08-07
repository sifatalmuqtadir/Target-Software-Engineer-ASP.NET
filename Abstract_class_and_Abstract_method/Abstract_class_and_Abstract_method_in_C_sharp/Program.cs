using Abstract_class_and_Abstract_method_in_C_sharp;

BankAccount account1 = new CreditAccount("C-101", "Jadir", 10000, 50000);
BankAccount account2 = new DebitAccount("D-201", "Sifat", 10000, 20000);

account1.ShowAccountInfo();
account1.Withdraw(15000);

Console.WriteLine("Final Balance: " + account1.Balance);
Console.WriteLine();

account2.ShowAccountInfo();
account2.Withdraw(15000);

Console.WriteLine("Final Balance: " + account2.Balance);

Console.ReadLine();