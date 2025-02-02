using System;

class FibonacciSequenceGenerator
{
    // Function to calculate and print the Fibonacci sequence up to the specified number of terms
    static void GenerateFibonacci(int terms)
    {
        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci sequence up to " + terms + " terms:");

        // Loop to print the Fibonacci sequence
        for (int i = 1; i <= terms; i++)
        {
            if (i == 1)
            {
                Console.Write(first + " ");  // First term
                continue;
            }
            if (i == 2)
            {
                Console.Write(second + " ");  // Second term
                continue;
            }
            next = first + second;  // Calculate the next term in the sequence
            Console.Write(next + " ");  
            first = second;  
            second = next;  
        }

        Console.WriteLine();  
    }

    // Main function 
    static void Main()
    {
        Console.WriteLine("Enter the number of terms you want in the Fibonacci sequence:");

        if (int.TryParse(Console.ReadLine(), out int terms) && terms > 0)  
        {
            GenerateFibonacci(terms);  
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }
    }
}
