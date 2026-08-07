using Method_overriding_in_C_;

CreditAccount ca = new CreditAccount();
ca.AccountNo = "CA-001";
ca.Name = "Jadir";
ca.AccountType = "Credit";
Console.WriteLine(ca.AccountNo);
Console.WriteLine(ca.Name);
Console.WriteLine(ca.AccountType);
Console.WriteLine(ca.deposit(25000));
Console.WriteLine(ca.withdraw(30000));
Console.WriteLine(ca.balance);
Console.WriteLine();


DebitAccount da = new DebitAccount();
da.AccountNo = "DA-001";
da.Name = "Rahim";
da.AccountType = "Debit";
Console.WriteLine(da.AccountNo);
Console.WriteLine(da.Name);
Console.WriteLine(da.AccountType);
Console.WriteLine(da.deposit(20000));
Console.WriteLine(da.withdraw(25000));
Console.WriteLine(da.balance);
Console.WriteLine();


DebitAccount da1 = new DebitAccount();
da1.AccountNo = "DA-002";
da1.Name = "Sifat";
da1.AccountType = "Debit";
Console.WriteLine(da1.AccountNo);
Console.WriteLine(da1.Name);
Console.WriteLine(da1.AccountType);
Console.WriteLine(da1.deposit(20000));
Console.WriteLine(da1.withdraw(15000));
Console.WriteLine(da1.balance);
Console.WriteLine();
