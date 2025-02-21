using System;
using System.IO;

class DivByZero
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        } 
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}
