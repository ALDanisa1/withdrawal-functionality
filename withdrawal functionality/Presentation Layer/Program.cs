// User Layer Entry Point
using System;
using withdrawal_functionality.DataBase_Layer;
using withdrawal_functionality.Logic_Layer;

public class Program
{
    static void Main()
    {
        // Initialize the SystemDB singleton
        var systemDB = SystemDB.Instance;

        // Create an instance of BankService with the SystemDB
        var bankService = new BankService(systemDB);

        // Print account details before transactions
        PrintAccountDetails(systemDB.GetAccount(1));
        PrintAccountDetails(systemDB.GetAccount(2));

        // Perform some basic operations
        bankService.Deposit(1, 500); // Deposit R500 into Savings Account with ID 1
        bankService.Withdraw(2, 2000); // Withdraw R2000 from Savings Account with ID 2

        // Print account details after transactions
        PrintAccountDetails(systemDB.GetAccount(1));
        PrintAccountDetails(systemDB.GetAccount(2));
    }

    static void PrintAccountDetails(IAccount account)
    {
        if (account != null)
        {
            Console.WriteLine($"Account ID: {account.Id}");
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
        Console.WriteLine();
    }
}
