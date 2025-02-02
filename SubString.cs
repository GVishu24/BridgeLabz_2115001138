using System;

class Substring
{
    static int CountSubstringOccurrences(string mainString, string subString)
    {
        if (mainString == null || subString == null || mainString.Length == 0 || subString.Length == 0)
            return 0;

        int count = 0;
        int mainLength = mainString.Length;
        int subLength = subString.Length;

        // Loop through the main string manually
        for (int i = 0; i <= mainLength - subLength; i++)
        {
            // Check if substring matches character by character
            bool match = true;
            for (int j = 0; j < subLength; j++)
            {
                if (mainString[i + j] != subString[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                count++;
            }
        }

        return count;
    }
	 static void Main()
    {
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();

        Console.WriteLine("Enter the substring to search for:");
        string subString = Console.ReadLine();

        int occurrences = CountSubstringOccurrences(mainString, subString);
        Console.WriteLine(string.Format("The substring '{0}' occurs {1} times in the main string.",subString,occurrences));
    }
}