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

    // Method to find factors of a number and return them as an array
    public static int[] GetFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }
        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int GetGreatestFactor(int number)
    {
        int[] factors = GetFactors(number);
        return factors[factors.Length - 1];
    }

    // Method to find the sum of the factors using factors array
    public static int GetSumOfFactors(int number)
    {
        int[] factors = GetFactors(number);
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using factors array
    public static long GetProductOfFactors(int number)
    {
        int[] factors = GetFactors(number);
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of the factors using factors array
    public static long GetProductOfCubeOfFactors(int number)
    {
        int[] factors = GetFactors(number);
        long product = 1;
        foreach (int factor in factors)
        {
            product *= (long)Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int sum = GetSumOfFactors(number) - number;
        return sum == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int sum = GetSumOfFactors(number) - number;
        return sum > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int sum = GetSumOfFactors(number) - number;
        return sum < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += Factorial(digit);
        }
        return sum == number;
    }

    // Helper method to calculate factorial
    private static int Factorial(int n)
    {
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        int number = 28; // Example number

        // Find the factors of the number
        int[] factors = GetFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        // Find the greatest factor
        Console.WriteLine("Greatest Factor: " + GetGreatestFactor(number));

        // Find the sum of the factors
        Console.WriteLine("Sum of Factors: " + GetSumOfFactors(number));

        // Find the product of the factors
        Console.WriteLine("Product of Factors: " + GetProductOfFactors(number));

        // Find the product of the cube of the factors
        Console.WriteLine("Product of Cube of Factors: " + GetProductOfCubeOfFactors(number));

        // Check if the number is a perfect number
        Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number));

        // Check if the number is an abundant number
        Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(number));

        // Check if the number is a deficient number
        Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(number));

        // Check if the number is a strong number
        Console.WriteLine("Is Strong Number: " + IsStrongNumber(number));
    }
}