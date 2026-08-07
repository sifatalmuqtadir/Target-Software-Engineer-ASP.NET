using Inheritance_relationship_in_C_;

CreditAccount ca  = new CreditAccount();
ca.Balance = 1000;
Console.WriteLine(ca.Withdraw(1500));
Console.WriteLine("Credit Account Balance: " + ca.Balance);

DebitAccount da = new DebitAccount();
da.Balance = 1000;
Console.WriteLine(da.Withdraw(1500));
Console.WriteLine("Debit Account Balance: " + da.Balance);
