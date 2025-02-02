using System;

public class Quadratic
{
    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c; // Calculate delta (b^2 - 4ac)
        double[] roots;

        // If delta is positive, two real roots exist
        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            roots = new double[] { root1, root2 };
        }
        // If delta is zero, one real root exists
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            roots = new double[] { root };
        }
        // If delta is negative, no real roots exist
        else
        {
            roots = new double[0]; // No real roots
        }

        return roots;
    }
}

class Program
{
    static void Main()
    {
        // Take user input for coefficients a, b, and c
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Call the FindRoots method to calculate the roots
        double[] roots = Quadratic.FindRoots(a, b, c);

        // Display the results
        if (roots.Length == 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"There is one real root: {roots[0]:0.00}");
        }
        else
        {
            Console.WriteLine($"There are two real roots: {roots[0]:0.00} and {roots[1]:0.00}");
        }
    }
}
