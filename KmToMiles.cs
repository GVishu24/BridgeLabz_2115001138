using System;

class Program
{
    // Function to convert kilometers to miles
    static double ConvertKmToMiles(double kilometers)
    {
        const double kmToMiles = 1.6; // 1 mile = 1.6 kilometers
        return kilometers / kmToMiles;
    }

    static void Main(string[] args)
    {
        // taking input
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());

        // function call
        double miles = ConvertKmToMiles(kilometers);

        // display
        Console.WriteLine(string.Format("The total miles is {0} miles for the given {1} kilometers.",miles,kilometers));
    }
}
