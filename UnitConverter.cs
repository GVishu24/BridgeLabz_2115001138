using System;
public class UnitConverter
{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double kmToMi = 0.621371; // Conversion factor from kilometers to miles
        return km * kmToMi;
    }

    // Method to convert miles to kilometers
    public static double ConvertMilesToKm(double mi)
    {
        double miToKm = 1.60934; // Conversion factor from miles to kilometers
        return mi * miToKm;
    }

    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double m)
    {
        double mToFt = 3.28084; // Conversion factor from meters to feet
        return m * mToFt;
    }

    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double ft)
    {
        double ftToM = 0.3048; // Conversion factor from feet to meters
        return ft * ftToM;
    }
}

class ConvertUnit
{
    static void Main()
    {
        // Example use cases for conversion

        // Kilometers to Miles
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        double mi = UnitConverter.ConvertKmToMiles(km);
        Console.WriteLine($"{km} kilometers is equal to {mi} miles.");

        // Miles to Kilometers
        Console.Write("Enter distance in miles: ");
        double miInput = Convert.ToDouble(Console.ReadLine());
        double kmConverted = UnitConverter.ConvertMilesToKm(miInput);
        Console.WriteLine($"{miInput} miles is equal to {kmConverted} kilometers.");

        // Meters to Feet
        Console.Write("Enter distance in meters: ");
        double m = Convert.ToDouble(Console.ReadLine());
        double ft = UnitConverter.ConvertMetersToFeet(m);
        Console.WriteLine($"{m} meters is equal to {ft} feet.");

        // Feet to Meters
        Console.Write("Enter distance in feet: ");
        double ftInput = Convert.ToDouble(Console.ReadLine());
        double mConverted = UnitConverter.ConvertFeetToMeters(ftInput);
        Console.WriteLine($"{ftInput} feet is equal to {mConverted} meters.");
    }
}
