using System;

class BMI_Calculator
{
    // Method to calculate BMI for each person
    public static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            // Convert height from cm to meters (divide by 100)
            double heightInMeters = data[i, 1] / 100;
            // BMI formula: weight / (height * height)
            data[i, 2] = data[i, 0] / (heightInMeters * heightInMeters);
        }
    }

    // Method to determine BMI status
    public static string[] GetBMIStatus(double[,] data)
    {
        string[] status = new string[data.GetLength(0)];

        for (int i = 0; i < data.GetLength(0); i++)
        {
            // Get BMI value for each person
            double bmi = data[i, 2];

            // Determine BMI status based on the value
            if (bmi <= 18.4)
                status[i] = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                status[i] = "Normal";
            else if (bmi >= 25.0 && bmi <= 39.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        return status;
    }
}

class Program
{
    static void Main()
    {
        // Declare 2D array to store weight, height, and BMI for 10 people
        double[,] data = new double[10, 3];

        // Taking user input for weight and height
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");
            Console.Write("Enter weight (in kg): ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (in cm): ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate BMI for each person
        BMI_Calculator.CalculateBMI(data);

        // Get BMI status for each person
        string[] status = BMI_Calculator.GetBMIStatus(data);

        // Display results
        Console.WriteLine("\nBMI Calculation and Status of All Individuals:");
        Console.WriteLine("Person\tWeight (kg)\tHeight (cm)\tBMI\tStatus");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}\t{data[i, 0]}\t\t{data[i, 1]}\t\t{data[i, 2]:0.00}\t{status[i]}");
        }
    }
}
