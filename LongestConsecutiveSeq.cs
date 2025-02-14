using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    public static int FindLongestConsecutiveSequence(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            // Check if it's the start of a sequence
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // Expand the sequence
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    public static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine("Longest Consecutive Sequence Length: " + FindLongestConsecutiveSequence(nums));
    }
}
