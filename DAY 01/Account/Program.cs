// See https://aka.ms/new-console-template for more information
using Banking;
// used to import from different location .


Account acc01= new Account();


Console.WriteLine(acc01.GetBalance());

acc01.SetBalance(17000);

Console.WriteLine(acc01.GetBalance());
acc01.DepositeAccount(10000);
acc01.WithdrawAccount(50000);