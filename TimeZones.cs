using System;

class TimeZones
{
    static void Main()
    {
        // Get the current UTC time
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;

        // Define the required time zones
        TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert UTC time to different time zones
        DateTime gmtTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow.UtcDateTime, gmtZone);
        DateTime istTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow.UtcDateTime, istZone);
        DateTime pstTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow.UtcDateTime, pstZone);

        // Display the results
        Console.WriteLine("Current Time in Different Time Zones:");
        Console.WriteLine("GMT: " + gmtTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("IST: " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("PST: " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}