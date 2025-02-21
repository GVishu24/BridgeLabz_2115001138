using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!");
        }
        if (amount > Balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawal successful, new balance: {Balance}");
    }
}

class Transaction
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000);

        try
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
