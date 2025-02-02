using System;

class RandomNumberGenerator
{
    // Method to generate an array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] numbers = new int[size];

        // Generate random 4-digit numbers
        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(1000, 10000); // 4-digit random numbers (1000 to 9999)
        }

        return numbers;
    }

    // Method to find the average, min, and max of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        double[] result = new double[3]; // Array to store average, min, and max

        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        // Calculate sum, min, and max
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        // Calculate average
        double average = (double)sum / numbers.Length;

        // Store results in the result array: [average, min, max]
        result[0] = average;
        result[1] = min;
        result[2] = max;

        return result;
    }
}

class Program
{
    static void Main()
    {
        RandomNumberGenerator generator = new RandomNumberGenerator();

        // Generate 5 random 4-digit numbers
        int size = 5;
        int[] randomNumbers = generator.Generate4DigitRandomArray(size);

        // Find the average, min, and max values
        double[] stats = generator.FindAverageMinMax(randomNumbers);

        // Display the generated random numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int num in randomNumbers)
        {
            Console.WriteLine(num);
        }

        // Display the average, min, and max values
        Console.WriteLine("\nAverage: " + stats[0]);
        Console.WriteLine("Minimum: " + stats[1]);
        Console.WriteLine("Maximum: " + stats[2]);
    }
}
