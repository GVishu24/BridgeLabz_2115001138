using System;

class BankAccount
{
    // Static variable shared across all instances
    private static string bankName = "ABC Bank";
    private static int totalAccounts = 0;
    
    // Readonly variable
    public readonly int AccountNumber;
    public string AccountHolderName { get; private set; }
    public double Balance { get; private set; }

    // Constructor using 'this' to resolve ambiguity
    public BankAccount(string AccountHolderName, int AccountNumber, double initialBalance)
    {
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber;
        this.Balance = initialBalance;
        totalAccounts++;
    }

    // Static method to get total accounts
    public static void GetTotalAccounts()
    {
        Console.WriteLine($"Total Bank Accounts: {totalAccounts}");
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. Remaining Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Invalid or insufficient balance for withdrawal.");
        }
    }

    // Method to display account details
    public void DisplayAccountInfo()
    {
        if (this is BankAccount)  // Using 'is' operator
        {
            Console.WriteLine("=== Account Details ===");
            Console.WriteLine($"Bank: {bankName}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating bank accounts
        BankAccount acc1 = new BankAccount("John Doe", 1001, 5000);
        BankAccount acc2 = new BankAccount("Jane Smith", 1002, 3000);
        
        // Display account details
        acc1.DisplayAccountInfo();
        acc2.DisplayAccountInfo();
        
        // Perform transactions
        acc1.Deposit(1500);
        acc1.Withdraw(2000);
        
        // Display total accounts
        BankAccount.GetTotalAccounts();
    }
}