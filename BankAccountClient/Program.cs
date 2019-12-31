using BankAccountClient.BankAccountService;
using System;

namespace BankAccountClient
{
    class Program
    {
        static void Main(string[] args)
        {
           BankAccountServiceClient bankAccountServiceClient = new BankAccountServiceClient();
            Amount amount = new Amount();
            amount.Value = 3200;
            bankAccountServiceClient.Deposit(amount);
            amount.Value = 3300;
            bankAccountServiceClient.Deposit(amount);
            amount.Value = 3400;
            bankAccountServiceClient.Deposit(amount);
            amount.Value = 800;
            bankAccountServiceClient.Withdraw(amount);
            amount.Value = 700;    
            bankAccountServiceClient.Withdraw(amount);
            amount.Value = 600;
            bankAccountServiceClient.Withdraw(amount);

            Console.WriteLine(bankAccountServiceClient.PrintStatements());

            Console.ReadLine();
        }
    }
}
