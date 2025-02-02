using System;

class TrigonometricFunction
{
    static void Main(string[] args)
    {
        Console.Write("Enter the angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        // Call the method to calculate trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine("Sine: " + results[0]);
        Console.WriteLine("Cosine: " + results[1]);
        Console.WriteLine("Tangent: " + results[2]);
    }

    // Method to calculate trigonometric functions
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert the angle from degrees to radians
        double radians = angle * (Math.PI / 180);

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Store the results in an array and return it
        double[] results = { sine, cosine, tangent };
        return results;
    }
}