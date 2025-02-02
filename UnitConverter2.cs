using System;

public class UnitConverter
{
    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3; // Conversion factor from yards to feet
        return yards * yards2feet;
    }

    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333; // Conversion factor from feet to yards
        return feet * feet2yards;
    }

    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701; // Conversion factor from meters to inches
        return meters * meters2inches;
    }

    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254; // Conversion factor from inches to meters
        return inches * inches2meters;
    }

    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54; // Conversion factor from inches to centimeters
        return inches * inches2cm;
    }
}

class Program
{
    static void Main()
    {
        // Example use cases for conversion

        // Yards to Feet
        Console.Write("Enter distance in yards: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        double feet = UnitConverter.ConvertYardsToFeet(yards);
        Console.WriteLine($"{yards} yards is equal to {feet} feet.");

        // Feet to Yards
        Console.Write("Enter distance in feet: ");
        double feetInput = Convert.ToDouble(Console.ReadLine());
        double yardsConverted = UnitConverter.ConvertFeetToYards(feetInput);
        Console.WriteLine($"{feetInput} feet is equal to {yardsConverted} yards.");

        // Meters to Inches
        Console.Write("Enter distance in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        double inches = UnitConverter.ConvertMetersToInches(meters);
        Console.WriteLine($"{meters} meters is equal to {inches} inches.");

        // Inches to Meters
        Console.Write("Enter distance in inches: ");
        double inchesInput = Convert.ToDouble(Console.ReadLine());
        double metersConverted = UnitConverter.ConvertInchesToMeters(inchesInput);
        Console.WriteLine($"{inchesInput} inches is equal to {metersConverted} meters.");

        // Inches to Centimeters
        Console.Write("Enter distance in inches: ");
        double inchesForCm = Convert.ToDouble(Console.ReadLine());
        double cm = UnitConverter.ConvertInchesToCentimeters(inchesForCm);
        Console.WriteLine($"{inchesForCm} inches is equal to {cm} centimeters.");
    }
}
