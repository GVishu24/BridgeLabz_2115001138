using System;
class Smallest{
	
    static void Main()
    {
        // input three numbers by user
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        double num3 = double.Parse(Console.ReadLine());

        // Check if the first number is the smallest
        bool isSmallest = num1 < num2 && num1 < num3;

        // Output
        Console.WriteLine(string.Format("Is the first number the smallest? {0}",isSmallest));
    }
}
