using System;
class CountDigits
{
    static void Main()
    {
        // input an integer
        Console.WriteLine("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        
        int count = 0; 

        // Handle the case when the number is 0
        if (number == 0)
        {
            count = 1;
        }
        else
        {
            // Use a loop to count digits
            while (number != 0)
            {
                // Remove the last digit from the number
                number /= 10;

                // Increment the count for each iteration
                count++;
            }
        }

        // Output
        Console.WriteLine("The number has " + count + " digits.");
    }
}
