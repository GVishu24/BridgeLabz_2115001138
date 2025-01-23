using System;

class FactorialFor
{
    static void Main()
    {
        // Input from user
        Console.WriteLine("Enter a positive integer to calculate its factorial:");
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (number < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Initialize factorial to 1
        int factorial = 1;

        // Compute factorial using a for loop
        for (int i = 1; i <= number; i++)
        {
            factorial *= i; // Multiply the current value of i
        }

        // Output 
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}
