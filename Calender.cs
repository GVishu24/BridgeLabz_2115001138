using System;

class CalendarProgram
{
    // Method to get the name of the month
    public static string GetMonthName(int month)
    {
        string[] months = { "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December" };
        return months[month - 1];
    }

    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get the number of days in a month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year))
        {
            return 29; // February in a leap year
        }
        return days[month - 1];
    }

    // Method to get the first day of the month using Zeller's Congruence
    public static int GetFirstDayOfMonth(int month, int year)
    {
        if (month < 3)
        {
            month += 12;
            year--;
        }
        int k = year % 100;
        int j = year / 100;
        return (1 + (13 * (month + 1)) / 5 + k + (k / 4) + (j / 4) - (2 * j)) % 7;
    }

    // Method to display the calendar for a given month and year
    public static void DisplayCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        Console.WriteLine($"\n  {monthName} {year}");
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        // Indentation for the first day
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("   ");
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,2} "); // Right-justified in a width of 2
            if ((day + firstDay) % 7 == 0) // Move to next line after Saturday
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine(); // Final new line
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        if (month < 1 || month > 12 || year < 1)
        {
            Console.WriteLine("Invalid input. Please enter a valid month and year.");
        }
        else
        {
            DisplayCalendar(month, year);
        }
    }
}
