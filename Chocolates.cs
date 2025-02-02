using System;

class Chocolates
{
    static void Main(string[] args)
    {
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // calculate chocolates per child and remaining chocolates
        int[] result = DistributeChocolate(numberOfChocolates, numberOfChildren);

        // Display the results
        Console.WriteLine("Each child gets: " + result[0] + " chocolates");
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }

    //  calculate chocolates per child and remaining chocolates
    public static int[] DistributeChocolate(int number, int divisor)
    {
        int chocolatesPerChild = number / divisor; // Chocolates each child gets
        int remainingChocolates = number % divisor; // Remaining chocolates

        // Store the results in an array and return it
        int[] result = { chocolatesPerChild, remainingChocolates };
        return result;
    }
}