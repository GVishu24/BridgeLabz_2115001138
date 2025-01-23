using System;
class SumUntilZero2
{
    static void Main()
    {
        // Initialize total to 0.0
        double total = 0.0;

        // Infinite while loop
        while (true)
        {
            Console.WriteLine("Enter a number (0 or negative to stop):");
            double userInput = double.Parse(Console.ReadLine()); // Get input from user

            // Check if the input is 0 or negative to break the loop
            if (userInput <= 0)
            {
                break;
            }

            // Add the user input to the total
            total += userInput;
        }

        // Display the total sum
        Console.WriteLine("The total sum is: " + total);
    }
}
