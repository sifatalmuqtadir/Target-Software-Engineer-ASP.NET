using Runtime_polymorphism_in_C_;

// A List of parent-class references
List<BankAccount> accounts = new List<BankAccount>();

// CreditAccount object
accounts.Add(new CreditAccount("C-101", "Jadir", 10000, 50000));

// DebitAccount object
accounts.Add(new DebitAccount("D-201", "Rahim", 10000, 20000));

// Processing all accounts using the parent type
foreach (BankAccount account in accounts)
{
    account.ShowAccountInfo();

    Console.WriteLine("Withdraw Amount: 15000");

    account.Withdraw(15000);

    Console.WriteLine("Balance After Withdrawal: " + account.Balance);

    Console.WriteLine("--------------------");
}

Console.ReadLine();