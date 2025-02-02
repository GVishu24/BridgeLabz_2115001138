using System;

class BasicCalculator
{
    // Function to perform addition
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Function to perform subtraction
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Function to perform multiplication
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Function to perform division
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;  // Return "Not a Number" to handle division by zero
        }
        return a / b;
    }

    // Function to get a valid double input from the user
    static double GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        double num;
        while (!double.TryParse(Console.ReadLine(), out num))  // Ensure valid input
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return num;
    }

    // Function to display the result
    static void DisplayResult(double result)
    {
        Console.WriteLine("The result is: " + result);
    }

    // Main function to run the program
    static void Main()
    {
        // Display the operation options
        Console.WriteLine("Basic Calculator:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int choice;
        while (true)
        {
            Console.WriteLine("Enter your choice (1, 2, 3, or 4):");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                break;
            else
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
        }

        // Get two numbers for calculation
        double num1 = GetInput("Enter the first number:");
        double num2 = GetInput("Enter the second number:");

        // Perform the selected operation
        double result = 0;
        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                break;
            case 2:
                result = Subtract(num1, num2);
                break;
            case 3:
                result = Multiply(num1, num2);
                break;
            case 4:
                result = Divide(num1, num2);
                break;
        }

        // Display the result
        DisplayResult(result);
    }
}
