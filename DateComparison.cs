using System;

class DateComparison
{
    static void Main()
    {
        // Prompt user for two date inputs
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the second date (yyyy-MM-dd): ");
        string input2 = Console.ReadLine();

        // Parse the input dates
        if (DateTime.TryParse(input1, out DateTime date1) && DateTime.TryParse(input2, out DateTime date2))
        {
            // Compare the dates
            int comparisonResult = date1.CompareTo(date2);

            // Display comparison results
            if (comparisonResult < 0)
            {
                Console.WriteLine("The first date is before the second date.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter valid dates in yyyy-MM-dd format.");
        }
    }
}
