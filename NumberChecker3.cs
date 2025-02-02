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

    // Method to reverse the digits array
    public static int[] ReverseDigitsArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }

    // Method to check if a number is a palindrome using the digits
    public static bool IsPalindrome(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[] reversedDigits = ReverseDigitsArray(digits);
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check if a number is a duck number using the digits array
    public static bool IsDuckNumber(int number)
    {
        if (number <= 0) return false; // Duck numbers are positive

        int[] digits = GetDigitsArray(number);
        foreach (int digit in digits)
        {
            if (digit == 0)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        int number = 153; // Example number

        // Find the count of digits
        Console.WriteLine("Count of digits: " + CountDigits(number));

        // Get digits array
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits array: " + string.Join(", ", digits));

        // Reverse digits array
        int[] reversedDigits = ReverseDigitsArray(digits);
        Console.WriteLine("Reversed digits array: " + string.Join(", ", reversedDigits));

        // Check if the number is a palindrome
        Console.WriteLine("Is Palindrome: " + IsPalindrome(number));

        // Check if the number is a duck number
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(number));
    }
}
