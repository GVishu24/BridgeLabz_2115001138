using System;

class TemperatureConverter
{
    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;  // Formula: (Fahrenheit - 32) * 5/9
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;  // Formula: (Celsius * 9/5) + 32
    }

    // Function to take input from the user
    static double GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        double temp;
        while (!double.TryParse(Console.ReadLine(), out temp))  // Ensure valid input
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return temp;
    }

    // Function to display the results
    static void DisplayResult(double inputTemp, double convertedTemp, string fromUnit, string toUnit)
    {
        Console.WriteLine($"{inputTemp} {fromUnit} is equal to {convertedTemp} {toUnit}.");
    }

    // Main function to run the program
    static void Main()
    {
        Console.WriteLine("Temperature Converter: Choose the conversion option");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");

        int choice;
        while (true)
        {
            Console.WriteLine("Enter your choice (1 or 2):");
            if (int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2))
                break;
            else
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }

        if (choice == 1)
        {
            double fahrenheit = GetInput("Enter temperature in Fahrenheit:");
            double celsius = FahrenheitToCelsius(fahrenheit);
            DisplayResult(fahrenheit, celsius, "Fahrenheit", "Celsius");
        }
        else
        {
            double celsius = GetInput("Enter temperature in Celsius:");
            double fahrenheit = CelsiusToFahrenheit(celsius);
            DisplayResult(celsius, fahrenheit, "Celsius", "Fahrenheit");
        }
    }
}
