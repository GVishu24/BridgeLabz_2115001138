using System;
using System.Collections.Generic;

class CircularTour
{
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        Queue<int> queue = new Queue<int>();
        int totalSurplus = 0, currentSurplus = 0, startIndex = 0;

        for (int i = 0; i < n; i++)
        {
            int balance = petrol[i] - distance[i];
            totalSurplus += balance;
            currentSurplus += balance;
            queue.Enqueue(i);

            // If currentSurplus becomes negative, remove front elements
            while (currentSurplus < 0 && queue.Count > 0)
            {
                int removedIndex = queue.Dequeue();
                currentSurplus -= (petrol[removedIndex] - distance[removedIndex]);
                startIndex = removedIndex + 1; 
            }
        }

        return (totalSurplus >= 0) ? startIndex : -1; // If totalSurplus < 0, no solution exists
    }

    public static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int start = FindStartingPoint(petrol, distance);
        Console.WriteLine(start == -1 ? "No Solution Exists" : $"Start at Petrol Pump {start}");
    }
}
