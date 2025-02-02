using System;

class Quotient
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        int[] res = RemainderAndQuotient(number, divisor);

        Console.WriteLine("Quotient: " + res[0]);
        Console.WriteLine("Remainder: " + res[1]);

        Console.WriteLine(string.Format("Quotient: {0}", res[0]));
        Console.WriteLine(string.Format("Remainder: {1}", res[0], res[1]));
    }

    // Method to find the quotient and remainder
    public static int[] RemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor; 
        int remainder = number % divisor; 

        // Store the results in an array and return it
        int[] res = { quotient, remainder };
        return res;
    }
}