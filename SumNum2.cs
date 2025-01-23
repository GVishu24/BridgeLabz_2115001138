using System;
class SumNum2
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.WriteLine("Enter a positive natural number:");
        int n = int.Parse(Console.ReadLine());

        // Check if the input is a natural number (greater than 0)
        if (n <= 0)
        {
            Console.WriteLine("The number must be a natural number (greater than 0).");
            return;
        }

        // Compute the sum using the formula
        int formulaSum = n * (n + 1) / 2;

        // Compute the sum using a for loop
        int loopSum = 0;
        for (int i = 1; i <= n; i++)
        {
            loopSum += i; // Add the current number to the sum
        }

        // Display results from both methods
        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Sum using for loop: " + loopSum);

        // Compare and verify the results
        if (formulaSum == loopSum)
        {
            Console.WriteLine("The results from both computations match! The calculation is correct.");
        }
        else
        {
            Console.WriteLine("The results from both computations do not match. Check the logic.");
        }
    }
}
