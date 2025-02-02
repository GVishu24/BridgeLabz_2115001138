using System;

public class UnitConverter
{
    // Method to convert Fahrenheit to Celsius
    public static double FtoC(double f)
    {
        double f2c = (f - 32) * 5 / 9; // Conversion from Fahrenheit to Celsius
        return f2c;
    }

    // Method to convert Celsius to Fahrenheit
    public static double CtoF(double c)
    {
        double c2f = (c * 9 / 5) + 32; // Conversion from Celsius to Fahrenheit
        return c2f;
    }

    // Method to convert pounds to kilograms
    public static double PtoKg(double p)
    {
        double p2kg = 0.453592; // Conversion from pounds to kilograms
        return p * p2kg;
    }

    // Method to convert kilograms to pounds
    public static double KgToP(double kg)
    {
        double kg2p = 2.20462; // Conversion from kilograms to pounds
        return kg * kg2p;
    }

    // Method to convert gallons to liters
    public static double GtoL(double g)
    {
        double g2l = 3.78541; // Conversion from gallons to liters
        return g * g2l;
    }

    // Method to convert liters to gallons
    public static double LtoG(double l)
    {
        double l2g = 0.264172; // Conversion from liters to gallons
        return l * l2g;
    }
}

class Program
{
    static void Main()
    {
        // Fahrenheit to Celsius
        Console.Write("Enter temperature in Fahrenheit: ");
        double f = Convert.ToDouble(Console.ReadLine());
        double c = UnitConverter.FtoC(f);
        Console.WriteLine(f + " Fahrenheit is equal to " + c + " Celsius.");

        // Celsius to Fahrenheit
        Console.Write("Enter temperature in Celsius: ");
        double cIn = Convert.ToDouble(Console.ReadLine());
        double fConverted = UnitConverter.CtoF(cIn);
        Console.WriteLine(cIn + " Celsius is equal to " + fConverted + " Fahrenheit.");

        // Pounds to Kilograms
        Console.Write("Enter weight in pounds: ");
        double p = Convert.ToDouble(Console.ReadLine());
        double kg = UnitConverter.PtoKg(p);
        Console.WriteLine(p + " pounds is equal to " + kg + " kilograms.");

        // Kilograms to Pounds
        Console.Write("Enter weight in kilograms: ");
        double kgIn = Convert.ToDouble(Console.ReadLine());
        double pConverted = UnitConverter.KgToP(kgIn);
        Console.WriteLine(kgIn + " kilograms is equal to " + pConverted + " pounds.");

        // Gallons to Liters
        Console.Write("Enter volume in gallons: ");
        double g = Convert.ToDouble(Console.ReadLine());
        double l = UnitConverter.GtoL(g);
        Console.WriteLine(g + " gallons is equal to " + l + " liters.");

        // Liters to Gallons
        Console.Write("Enter volume in liters: ");
        double lIn = Convert.ToDouble(Console.ReadLine());
        double gConverted = UnitConverter.LtoG(lIn);
        Console.WriteLine(lIn + " liters is equal to " + gConverted + " gallons.");
    }
}
