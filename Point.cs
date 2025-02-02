using System;

public class PointCalculator
{
    // Method to calculate the Euclidean distance between two points
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // Method to calculate the equation of a line (slope and y-intercept) given two points
    public static (double slope, double yIntercept) CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        if (x1 == x2)
        {
            throw new ArgumentException("The line is vertical, slope is undefined.");
        }

        double slope = (y2 - y1) / (x2 - x1);
        double yIntercept = y1 - slope * x1;
        return (slope, yIntercept);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinates of the first point (x1, y1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinates of the second point (x2, y2):");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate Euclidean distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean Distance: {distance:F2}");

        try
        {
            // Calculate equation of the line
            var (slope, yIntercept) = CalculateLineEquation(x1, y1, x2, y2);
            Console.WriteLine($"Equation of the line: y = {slope:F2}x + {yIntercept:F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
