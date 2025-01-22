using System;

class FeetToYard
{
    // Function to convert feet to yards and miles
    static void ConvertDistance(double distanceInFeet)
    {
        // Conversion factors
        const double feetPerYard = 3;  // 1 yard = 3 feet
        const double yardsPerMile = 1760;  // 1 mile = 1760 yards

        // Convert feet to yards
        double distanceInYards = distanceInFeet / feetPerYard;

        // Convert yards to miles
        double distanceInMiles = distanceInYards / yardsPerMile;

        // Display the results
        Console.WriteLine("The distance in yards is: " + distanceInYards);
        Console.WriteLine("The distance in miles is: " + distanceInMiles);
    }

    static void Main(string[] args)
    {
        // Take user input for the distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Call the function to convert the distance and display the result
        ConvertDistance(distanceInFeet);
    }
}
