using System;

class Parimeter
{
    // Function to calculate the side of the square from the perimeter
    static double CalculateSide(double perimeter)
    {
        return perimeter / 4;
    }

    static void Main(string[] args)
    {
        // user input for the perimeter
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Call the function 
        double side = CalculateSide(perimeter);

        // Display
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
