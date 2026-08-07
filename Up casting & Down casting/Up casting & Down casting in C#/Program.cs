using Up_casting___Down_casting_in_C_;

// Creating child objects
CreditAccount creditAccount = new CreditAccount();

creditAccount.AccountNo = "C-101";
creditAccount.CustomerName = "Jadir";
creditAccount.CreditLimit = 50000;


DebitAccount debitAccount = new DebitAccount();

debitAccount.AccountNo = "D-201";
debitAccount.CustomerName = "Rahim";
debitAccount.DailyWithdrawLimit = 20000;


// Upcasting
BankAccount account1 = creditAccount;
BankAccount account2 = debitAccount;


Console.WriteLine("Account 1 Information:");

account1.ShowAccountInfo();

Console.WriteLine();


Console.WriteLine("Account 2 Information:");

account2.ShowAccountInfo();

Console.WriteLine();


// These will give errors because
// account1 and account2 are BankAccount references.

// account1.ShowCreditLimit();
// account2.ShowDailyWithdrawLimit();


// Downcasting account1 to CreditAccount
CreditAccount credit = (CreditAccount)account1;

credit.ShowCreditLimit();


// Downcasting account2 to DebitAccount
DebitAccount debit =(DebitAccount)account2;

debit.ShowDailyWithdrawLimit();


Console.ReadLine();