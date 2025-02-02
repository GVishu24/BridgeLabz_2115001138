using System;

class PrimeNumberChecker
{
    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1) 
            return false;  // Numbers less than or equal to 1 are not prime
        for (int i = 2; i <= Math.Sqrt(number); i++)  // Check up to the square root of the number
        {
            if (number % i == 0) 
                return false;  // If the number is divisible by any number other than 1 and itself, it's not prime
        }
        return true;  // If no divisors were found, the number is prime
    }

    // Main function to run the program
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is prime: ");
        
        if (int.TryParse(Console.ReadLine(), out int number))  // Read and parse user input
        {
            bool result = IsPrime(number);  // Call the IsPrime function
            
            if (result)
                Console.WriteLine(number + " is a prime number.");
            else
                Console.WriteLine(number + " is not a prime number.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
