using System;
class LeapYearChecker
{
    // Method to check if a year is a Leap Year
    public static bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("Year must be 1582 or greater.");
            return false;
        }

        // Leap year conditions:
        // - Year is divisible by 4
        // - Year is NOT divisible by 100, unless it is also divisible by 400
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true; 
        }
        else
        {
            return false; 
        }
    }

    static void Main()
    {
        // Take user input for the year
        Console.Write("Enter a year: ");
        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("Please enter a valid year.");
            return;
        }

        // Check if the year is a leap year and print the result
        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}
