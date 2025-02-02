using System;

public class CollinearChecker
{
    // Method to check if three points are collinear using the slope formula
    public static bool ArePointsCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return Math.Abs(slopeAB - slopeBC) < 1e-9 && Math.Abs(slopeAB - slopeAC) < 1e-9;
    }

    // Method to check if three points are collinear using the area of the triangle formula
    public static bool ArePointsCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return Math.Abs(area) < 1e-9; // If area is 0, points are collinear
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinates of point A (x1, y1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinates of point B (x2, y2):");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coordinates of point C (x3, y3):");
        double x3 = Convert.ToDouble(Console.ReadLine());
        double y3 = Convert.ToDouble(Console.ReadLine());

        // Check collinearity using the slope formula
        bool isCollinearUsingSlope = ArePointsCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        Console.WriteLine($"Are points collinear using slope formula: {isCollinearUsingSlope}");

        // Check collinearity using the area formula
        bool isCollinearUsingArea = ArePointsCollinearUsingArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine($"Are points collinear using area formula: {isCollinearUsingArea}");
    }
}
