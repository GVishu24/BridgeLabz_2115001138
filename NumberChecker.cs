using System;

public class NumberChecker
{
    // Method to check whether the number is positive or negative
    public static string IsPositiveOrNegative(int num)
    {
        if (num > 0)
        {
            return "Positive";
        }
        else if (num < 0)
        {
            return "Negative";
        }
        else
        {
            return "Zero";  // Case for zero
        }
    }

    // Method to check if the number is even or odd
    public static string IsEvenOrOdd(int num)
    {
        if (num % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }

    // Method to compare two numbers
    public static int CompareNumbers(int num1, int num2)
    {
        if (num1 > num2)
        {
            return 1;  // num1 is greater than num2
        }
        else if (num1 == num2)
        {
            return 0;  // num1 is equal to num2
        }
        else
        {
            return -1; // num1 is less than num2
        }
    }
}

class Program
{
    static void Main()
    {
        // Array to store 5 numbers
        int[] numbers = new int[5];

        // Taking user input for 5 numbers
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Loop through the array and check each number
        for (int i = 0; i < numbers.Length; i++)
        {
            string result = NumberChecker.IsPositiveOrNegative(numbers[i]);
            Console.WriteLine("Number " + (i + 1) + " is " + result);

            if (numbers[i] > 0) // If the number is positive, check if it's even or odd
            {
                string evenOddResult = NumberChecker.IsEvenOrOdd(numbers[i]);
                Console.WriteLine("It is " + evenOddResult);
            }
        }

        // Compare the first and last element of the array
        int comparisonResult = NumberChecker.CompareNumbers(numbers[0], numbers[4]);
        
        // Display the result of the comparison
        if (comparisonResult == 1)
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else if (comparisonResult == 0)
        {
            Console.WriteLine("The first number is equal to the last number.");
        }
        else
        {
            Console.WriteLine("The first number is less than the last number.");
        }
    }
}
