using System;

class Largest
{
    static void Main()
    {
        // input three numbers
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        double num3 = double.Parse(Console.ReadLine());

        // Check if each number is the largest
        bool isFirstLargest = num1 > num2 && num1 > num3;
        bool isSecondLargest = num2 > num1 && num2 > num3;
        bool isThirdLargest = num3 > num1 && num3 > num2;

        // Output 
		Console.WriteLine("Is the first number the largest? " + isFirstLargest);
        Console.WriteLine("Is the second number the largest? " + isSecondLargest);
        Console.WriteLine("Is the third number the largest? " + isThirdLargest);
    }
}

/*
using System;

class Program
{
    // Function to check if a number is the largest
    static bool IsLargest(double number, double other1, double other2)
    {
        return number > other1 && number > other2;
    }

    static void Main()
    {
        // Input: Get three numbers from the user
        Console.WriteLine("Enter the first number:");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        double number3 = double.Parse(Console.ReadLine());

        // Call the function for each number
        bool isFirstLargest = IsLargest(number1, number2, number3);
        bool isSecondLargest = IsLargest(number2, number1, number3);
        bool isThirdLargest = IsLargest(number3, number1, number2);

        // Output the results using concatenation
        Console.WriteLine("Is the first number the largest? " + isFirstLargest);
        Console.WriteLine("Is the second number the largest? " + isSecondLargest);
        Console.WriteLine("Is the third number the largest? " + isThirdLargest);
    }
}
*/