using System;
class SumUntilZero
{
    static void Main()
    {
        // Initialize total to 0.0
        double total = 0.0;

        // Variable to store user input
        double userInput;

        // Loop until user enters 0
        do
        {
            Console.WriteLine("Enter a number (0 to stop):");
            userInput = double.Parse(Console.ReadLine()); // Get input from user

            // Add user input to total if it's not 0
            total += userInput;

        } while (userInput != 0); // Continue while user input is not 0

        // Display 
        Console.WriteLine("The total sum is: " + total);
    }
}
