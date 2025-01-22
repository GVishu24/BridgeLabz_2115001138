using System;

class Program
{
    static void Main(string[] args)
    {
        // input height in centimeters
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        const double cmPerInch = 2.54;
        const int inchesPerFoot = 12; 

        // Convert height to inches
        double totalInches = heightCm / cmPerInch;

        // Convert to feet and remaining inches
        int feet = (int)(totalInches / inchesPerFoot);
        double inches = totalInches % inchesPerFoot;

        // Display the result
        Console.WriteLine(string.Format("Your height in cm is {0}, while in feet is {1} and inches is {2}.",heightCm,feet,inches));
    }
}
