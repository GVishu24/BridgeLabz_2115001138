using System;

class Anagram
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        bool result = AreAnagrams(str1, str2);

        if (result)
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }

    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false; // Different lengths → not anagrams

        int[] charCount = new int[256]; // ASCII character frequency array

        // Count frequency of characters in str1
        for (int i = 0; i < str1.Length; i++)
        {
            charCount[str1[i]]++;
            charCount[str2[i]]--; // Subtract for str2 simultaneously
        }

        // Check if all counts are zero
        for (int i = 0; i < 256; i++)
        {
            if (charCount[i] != 0)
                return false;
        }

        return true;
    }
}



using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int primeNumber = NthPrime(n);

        Console.WriteLine($"The {n}th prime number is: {primeNumber}");
    }

    static int NthPrime(int n)
    {
        int count = 0;
        int num = 2;

        while (true)
        {
            if (IsPrime(num))
            {
                count++;
                if (count == n)
                {
                    return num;
                }
            }
            num++;
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(num));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (num % i == 0) return false;
        }

        return true;
    }
}