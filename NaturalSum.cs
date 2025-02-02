using System;
class NaturalNumberSum
{
    // Method to calculate the sum of n natural numbers using recursion
    public static int SumUsingRecursion(int n)
    {
        // Base case: if n is 1, return 1
        if (n == 1)
        {
            return 1;
        }
        // Recursive case: sum of n = n + sum of (n-1)
        return n + SumUsingRecursion(n - 1);
    }

    // Method to calculate the sum of n natural numbers using the formula n*(n+1)/2
    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    static void Main()
    {
        // Take user input
        Console.Write("Enter a natural number: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Please enter a valid natural number greater than 0.");
            return;
        }

        // Calculate the sum using recursion
        int recursiveSum = SumUsingRecursion(n);
        
        // Calculate the sum using the formula
        int formulaSum = SumUsingFormula(n);
        
        // Display the results
        Console.WriteLine("Sum of first " + n + " natural numbers using recursion: " + recursiveSum);
        Console.WriteLine("Sum of first " + n + " natural numbers using formula: " + formulaSum);
        
        // Compare both results
        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("Both methods give the correct result.");
        }
        else
        {
            Console.WriteLine("There is a mismatch in the results.");
        }
    }
}
