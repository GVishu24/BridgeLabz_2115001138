using System;
class DateArithmetic
{
    static void Main()
    {
        // input date
        Console.Write("Enter a date (yyyy-MM-dd): ");
        string input = Console.ReadLine();

        // Parse the input date
        if (DateTime.TryParse(input, out DateTime date))
        {
            // Add 7 days, 1 month, and 2 years
            DateTime modifiedDate = date.AddDays(7).AddMonths(1).AddYears(2);
            
            // Subtract 3 weeks (21 days)
            DateTime finalDate = modifiedDate.AddDays(-21);

            // Display results
            Console.WriteLine($"Original Date: {date:yyyy-MM-dd}");
            Console.WriteLine($"After Adding: {modifiedDate:yyyy-MM-dd}");
            Console.WriteLine($"After Subtracting 3 Weeks: {finalDate:yyyy-MM-dd}");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a valid date in yyyy-MM-dd format.");
        }
    }
}
