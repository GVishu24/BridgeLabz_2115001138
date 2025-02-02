using System;
class DateFormatting
{
    static void Main()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Display the date in different formats
        Console.WriteLine("Date in dd/MM/yyyy format: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date in yyyy-MM-dd format: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Date in EEE, MMM dd, yyyy format: " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}