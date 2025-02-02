using System;

class GcdLcmCalculator
{
    // Function to calculate the Greatest Common Divisor (GCD) using the Euclidean algorithm
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate the Least Common Multiple (LCM) using the formula
    static int CalculateLCM(int a, int b)
    {
        return Math.Abs(a * b) / CalculateGCD(a, b);  // LCM = |a * b| / GCD(a, b)
    }

    // Function to take input from the user
    static void GetInput(out int num1, out int num2)
    {
        Console.WriteLine("Enter the first number:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = int.Parse(Console.ReadLine());
    }

    // Function to display the results
    static void DisplayResults(int num1, int num2, int gcd, int lcm)
    {
        Console.WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }

    // Main function to run the program
    static void Main()
    {
        int num1, num2;

        // Get user input for the two numbers
        GetInput(out num1, out num2);

        // Calculate the GCD and LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2);

        // Display the results
        DisplayResults(num1, num2, gcd, lcm);
    }
}
