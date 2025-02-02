using System;

public class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        int count = 0;
        number = Math.Abs(number);
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // Method to store the digits of the number in a digits array
    public static int[] GetDigitsArray(int number)
    {
        number = Math.Abs(number);
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to find the sum of the digits of a number using the digits array
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of the squares of the digits of a number using the digits array
    public static int SumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    // Method to check if a number is a Harshad number using the digits array
    public static bool IsHarshadNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int sumOfDigits = SumOfDigits(digits);
        return number % sumOfDigits == 0;
    }

    // Method to find the frequency of each digit in the number
    public static int[,] DigitFrequency(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[,] frequency = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }

    public static void Main(string[] args)
    {
        int number = 153; // Example number

        // Find the count of digits
        Console.WriteLine("Count of digits: " + CountDigits(number));

        // Get digits array
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits array: " + string.Join(", ", digits));

        // Find the sum of digits
        Console.WriteLine("Sum of digits: " + SumOfDigits(digits));

        // Find the sum of squares of digits
        Console.WriteLine("Sum of squares of digits: " + SumOfSquaresOfDigits(digits));

        // Check if the number is a Harshad number
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number));

        // Find the frequency of each digit
        int[,] frequency = DigitFrequency(number);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine($"Digit {frequency[i, 0]}: {frequency[i, 1]} times");
            }
        }
    }
}