using System;

public class FriendFinder
{
    // Method to find the youngest among the 3 friends
    public string FindYoungest(int[] ages)
    {
        int minAge = ages[0];
        string youngestFriend = "Amar";

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                if (i == 1) youngestFriend = "Akbar";
                else if (i == 2) youngestFriend = "Anthony";
            }
        }

        return youngestFriend;
    }

    // Method to find the tallest among the 3 friends
    public string FindTallest(double[] heights)
    {
        double maxHeight = heights[0];
        string tallestFriend = "Amar";

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                if (i == 1) tallestFriend = "Akbar";
                else if (i == 2) tallestFriend = "Anthony";
            }
        }

        return tallestFriend;
    }
}

class Program
{
    static void Main()
    {
        // Arrays to store ages and heights of the 3 friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Taking user input for ages and heights
        Console.Write("Enter age of Amar: ");
        ages[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter age of Akbar: ");
        ages[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter age of Anthony: ");
        ages[2] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height of Amar (in meters): ");
        heights[0] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of Akbar (in meters): ");
        heights[1] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of Anthony (in meters): ");
        heights[2] = Convert.ToDouble(Console.ReadLine());

        // Create an instance of FriendFinder class
        FriendFinder finder = new FriendFinder();

        // Find the youngest and tallest friends
        string youngest = finder.FindYoungest(ages);
        string tallest = finder.FindTallest(heights);

        // Display the results
        Console.WriteLine("The youngest friend is: " + youngest);
        Console.WriteLine("The tallest friend is: " + tallest);
    }
}
