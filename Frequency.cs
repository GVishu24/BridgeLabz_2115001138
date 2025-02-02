/*
using System;
class Frequency{
	static char FindMostFrequent{
		int[] frequency = new int[256];
		foreach (char c in input){
			frequency++;
		}
		char mostFrequentchar = '\0';
		int maxFrequency = 0;
		for (int i = 0; i < frequency.Length; i++){
			if frequency[i] > maxFrequency{
				maxFrequency = frequency[i];
				mostFrequentchar = char[i];
			}
		}
		return mostFrequentchar;
	}
	static void Main (string[] args){
		Console.WriteLine("Enter a string: ");
		string input = Console.ReadLine();
		char mostFrequent = FindMostFrequent(input);
		Console.ReadLine("Most frequent character: "+ mostFrequent);
	}
}
*/
/*
using System; 
 
class Frequent 
{ 
    static void Main() 
    { 
        Console.Write("Enter a string: ");         
		string input = Console.ReadLine(); 
 
        char mostFrequent = FindMostFrequentCharacter(input); 
 
        Console.WriteLine("Most Frequent Character: " + mostFrequent);     
	} 
 
    static char FindMostFrequentCharacter(string input) 
    { 
        int[] frequency = new int[256];  
 
        foreach (char c in input) 
        {
			frequency[c]++; 
        } 
 
        char mostFrequentChar = '\0';         
		int maxFrequency = 0; 
 
        for (int i = 0; i < 256; i++) 
        {
			if (frequency[i] > maxFrequency){
				maxFrequency = frequency[i];
				mostFrequentChar = (char)i;  
            } 
        } 
        return mostFrequentChar; 
    }
}
*/
using System;

class MostFrequentCharacter
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        char mostFrequentChar = FindMostFrequentCharacter(input);
        Console.WriteLine("Most Frequent Character: "+mostFrequentChar);
    }

    static char FindMostFrequentCharacter(string str)
    {
        if (string.IsNullOrEmpty(str))
            return '\0'; // Return null character if string is empty

        int[] frequency = new int[256]; // Array to store character counts
        int maxCount = 0;
        char mostFrequent = str[0];

        // Count occurrences of each character
        for (int i = 0; i < str.Length; i++)
        {
            frequency[str[i]]++;

            // Update most frequent character if current one has higher count
            if (frequency[str[i]] > maxCount)
            {
                maxCount = frequency[str[i]];
                mostFrequent = str[i];
            }
        }

        return mostFrequent;
    }
}


