using System;

class FactorCalculator
{
    // Method to find factors and return them in an array
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop to count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Second loop to save the factors into an array
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // Method to calculate the sum of the factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to calculate the product of the factors
    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to calculate the sum of the squares of the factors
    public static double SumOfSquaresOfFactors(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find factors
        int[] factors = FindFactors(number);

        // Display the factors
        Console.WriteLine("Factors of " + number + ": ");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        // Calculate and display the sum, sum of squares, and product of factors
        int sum = SumOfFactors(factors);
        int product = ProductOfFactors(factors);
        double sumOfSquares = SumOfSquaresOfFactors(factors);

        Console.WriteLine("Sum of factors: " + sum);
        Console.WriteLine("Product of factors: " + product);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }
}
