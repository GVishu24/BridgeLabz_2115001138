using System;
class MultiDimensionalArray
{
    static void Main(string[] args)
    {
        // Declare the 2D array
        int[,] arr = new int[3, 3];

        // Input the elements of the 2D array
        Console.WriteLine("Enter the elements of the 2D Array:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Display the elements and calculate the sum
        int sum = 0;
        Console.WriteLine("The elements of the 2D Array are:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + " ");
                sum += arr[i, j];
            }
            Console.WriteLine();
        }

       // Display the sum of the elements
        Console.WriteLine("The sum of the elements of the 2D Array is: " + sum);
    }
}
