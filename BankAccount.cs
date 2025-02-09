using System;

class BankAccount
{
    // Static variable shared across all accounts
    private static string bankName = "Global Bank";
    private static int totalAccounts = 0;
    
    // Readonly variable
    public readonly int AccountNumber;
    public string AccountHolderName;
    public double Balance;

    // Constructor using 'this' to resolve ambiguity
    public BankAccount(int AccountNumber, string AccountHolderName, double Balance)
    {
        this.AccountNumber = AccountNumber;
        this.AccountHolderName = AccountHolderName;
        this.Balance = Balance;
        totalAccounts++;
    }

    // Static method to display total accounts
    public static void GetTotalAccounts()
    {
        Console.WriteLine($"Total Accounts: {totalAccounts}");
    }

    // Method to display account details
    public void DisplayAccountInfo()
    {
        if (this is BankAccount)  
        {
            Console.WriteLine("=== Bank Account Details ===");
            Console.WriteLine($"Bank Name: {bankName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount(1001, "Lana Ray", 5000.75);
        BankAccount account2 = new BankAccount(1002, "Vishu Gupta", 12000.50);
        
        account1.DisplayAccountInfo();
        account2.DisplayAccountInfo();
        
        BankAccount.GetTotalAccounts();
    }
}
