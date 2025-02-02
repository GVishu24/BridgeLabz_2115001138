using System;

class FactorialCalculator
{
    // Function to take input from the user
    static int GetInput()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        int number;
        
        // Ensure the user inputs a valid integer
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
        
        return number;
    }

    // Recursive function to calculate the factorial of a number
    static long CalculateFactorial(int number)
    {
        if (number == 0 || number == 1)  // Base case: factorial of 0 or 1 is 1
            return 1;
        else
            return number * CalculateFactorial(number - 1);  // Recursive case
    }

    // Function to display the result
    static void DisplayResult(int number, long factorial)
    {
        Console.WriteLine("The factorial of " + number + " is " + factorial + ".");
    }

    // Main function to run the program
    static void Main()
    {
        int number = GetInput();  
        long factorial = CalculateFactorial(number);  
        DisplayResult(number, factorial);  
    }
}
