using System;

class NumberGuessingGame
{
    // Function to generate a random guess between the specified lower and upper bounds
    static int GenerateGuess(int lower, int upper)
    {
        Random rand = new Random();
        return rand.Next(lower, upper + 1);
    }

    // Function to get feedback from the user
    static string GetFeedback()
    {
        while (true)
        {
            Console.WriteLine("Is the guess correct, too high, or too low? (Enter 'correct', 'high', or 'low'):");
            string feedback = Console.ReadLine().ToLower().Trim();

            if (feedback == "correct" || feedback == "high" || feedback == "low")
            {
                return feedback;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'correct', 'high', or 'low'.");
            }
        }
    }

    // Main function to run the game
    static void PlayGame()
    {
        int lower = 1;
        int upper = 100;
        int guess = GenerateGuess(lower, upper);

        Console.WriteLine("Think of a number between 1 and 100, and I'll try to guess it!");

        while (true)
        {
            Console.WriteLine($"My guess is: {guess}");
            string feedback = GetFeedback();

            if (feedback == "correct")
            {
                Console.WriteLine($"Hooray! I guessed your number {guess} correctly!");
                break;
            }
            else if (feedback == "high")
            {
                upper = guess - 1;
            }
            else if (feedback == "low")
            {
                lower = guess + 1;
            }

            guess = GenerateGuess(lower, upper);
        }
    }

    // Entry point to start the game
    static void Main()
    {
        PlayGame();
    }
}
