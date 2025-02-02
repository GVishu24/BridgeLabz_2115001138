using System;

class FootballTeam
{
    // Method to generate random heights for the players
    public int[] GenerateHeights(int size)
    {
        Random rand = new Random();
        int[] heights = new int[size];

        // Generate random heights between 150 and 250 cm for each player
        for (int i = 0; i < size; i++)
        {
            heights[i] = rand.Next(150, 251); // 150 to 250 cm (inclusive of 150, exclusive of 251)
        }

        return heights;
    }

    // Method to find the sum of all elements (heights)
    public int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Method to find the mean height
    public double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        double mean = (double)sum / heights.Length;
        return mean;
    }

    // Method to find the shortest height
    public int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    // Method to find the tallest height
    public int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}

class Program
{
    static void Main()
    {
        FootballTeam team = new FootballTeam();

        // Generate random heights for 11 players
        int size = 11;
        int[] heights = team.GenerateHeights(size);

        // Calculate sum, mean, shortest, and tallest heights
        int sum = team.FindSum(heights);
        double mean = team.FindMean(heights);
        int shortest = team.FindShortest(heights);
        int tallest = team.FindTallest(heights);

        // Display the heights of the players
        Console.WriteLine("Heights of the 11 players (in cm):");
        foreach (int height in heights)
        {
            Console.WriteLine(height);
        }

        // Display the calculated results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Sum of heights: {sum} cm");
        Console.WriteLine($"Mean height: {mean:0.00} cm");
        Console.WriteLine($"Shortest height: {shortest} cm");
        Console.WriteLine($"Tallest height: {tallest} cm");
    }
}
