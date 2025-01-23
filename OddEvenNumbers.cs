using System;
class OddEvenNumbers
{
    static void Main()
    {
        // Input from user
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a natural number
        if (number <= 0)
        {
            Console.WriteLine("Please enter a natural number greater than 0.");
            return;
        }

        // Iterate from 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            // Check if the number is odd or even
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is an even number.");
            }
            else
            {
                Console.WriteLine(i + " is an odd number.");
            }
        }
    }
}
