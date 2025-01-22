using System;

class Calculator
{
    // addition function
    static double Add(double number1, double number2)
    {
        return number1 + number2;
    }

    // subtraction function
    static double Subtract(double number1, double number2)
    {
        return number1 - number2;
    }

    // multiplication function
    static double Multiply(double number1, double number2)
    {
        return number1 * number2;
    }

    // division function
    static double Divide(double number1, double number2)
    {
        if (number2 != 0)
        {
            return number1 / number2;
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
            return double.NaN; // Return "Not a Number" for invalid division
        }
    }

    static void Main(string[] args)
    {
        // user input for the two numbers
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations using functions
        double addition = Add(number1, number2);
        double subtraction = Subtract(number1, number2);
        double multiplication = Multiply(number1, number2);
        double division = Divide(number1, number2);

        // Display the results 
        Console.WriteLine("Addition: " + number1 + " + " + number2 + " = " + addition);
        Console.WriteLine("Subtraction: " + number1 + " - " + number2 + " = " + subtraction);
        Console.WriteLine("Multiplication: " + number1 + " * " + number2 + " = " + multiplication);

        if (!double.IsNaN(division))
        {
            Console.WriteLine("Division: " + number1 + " / " + number2 + " = " + division);
        }
    }
}
