using System;

class PalindromeChecker
{
    // Function to take input from the user
    static string GetInput()
    {
        Console.WriteLine("Enter a string to check if it is a palindrome:");
        return Console.ReadLine();
    }

    // Function to check if a given string is a palindrome
    static bool IsPalindrome(string input)
    {
        // Remove any spaces and convert the string to lowercase to handle case and spaces
        input = input.Replace(" ", "").ToLower();

        int start = 0;
        int end = input.Length - 1;

        // Check characters from both ends toward the center
        while (start < end)
        {
            if (input[start] != input[end])
                return false;  // Not a palindrome if characters don't match
            start++;
            end--;
        }

        return true;  // The string is a palindrome
    }

    // Function to display the result
    static void DisplayResult(string input, bool result)
    {
        if (result)
            Console.WriteLine("\"" + input + "\" is a palindrome.");
        else
            Console.WriteLine("\"" + input + "\" is not a palindrome.");
    }

    // Main function to run the program
    static void Main()
    {
        string input = GetInput();  // Get the input string
        bool result = IsPalindrome(input);  // Check if the string is a palindrome
        DisplayResult(input, result);  // Display the result
    }
}
