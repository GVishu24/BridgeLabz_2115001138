using System;
class Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Circle Details:");
        Console.WriteLine("Radius: " + Radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        circle.DisplayDetails();
    }
}