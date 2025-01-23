using System;

class Factorial
{
    static void Main()
    {
        // Input number
        Console.WriteLine("Enter a positive integer to calculate its factorial:");
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (number < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Initialize variables 
        int factorial = 1;
        int counter = number;

        // Compute factorial using a while loop
        while (counter > 0)
        {
            factorial *= counter; 
            counter--;            
        }

        // Output 
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}
