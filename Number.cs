using System;
class Program
{
    static void Main()
    {
        // Input number
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        // Check if the number is positive, negative, or zero
        if (num > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (num < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}