using System;

class Replace
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Enter the word to replace:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter the new word:");
        string newWord = Console.ReadLine();

        string result = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Modified Sentence: " + result);
    }

    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        int sentenceLength = sentence.Length;
        int oldWordLength = oldWord.Length;
        string result = "";

        for (int i = 0; i < sentenceLength; i++)
        {
            // Check if oldWord matches at position i
            if (i + oldWordLength <= sentenceLength && sentence.Substring(i, oldWordLength) == oldWord)
            {
                result += newWord; // Replace word
                i += oldWordLength - 1; // Skip the replaced word in the loop
            }
            else
            {
                result += sentence[i]; // Copy character if no match
            }
        }

        return result;
    }
}
