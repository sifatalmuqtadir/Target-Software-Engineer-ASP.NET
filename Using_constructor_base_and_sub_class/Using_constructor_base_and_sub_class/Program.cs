using Using_constructor_base_and_sub_class;

CreditAccount creditAccount = new CreditAccount("C-101", "Jadir", 50000);

creditAccount.Balance = 10000;

creditAccount.ShowAccountInfo();
creditAccount.ShowCreditLimit();

Console.WriteLine();

DebitAccount debitAccount = new DebitAccount("D-201", "Rahim", 20000);

debitAccount.Balance = 30000;

debitAccount.ShowAccountInfo();
debitAccount.ShowDailyWithdrawLimit();

Console.ReadLine();