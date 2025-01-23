using System;

class CastVote
{
    static void Main()
    {
        // input age
        Console.WriteLine("Enter the person's age:");
        int age = int.Parse(Console.ReadLine());

        // Check if the person is eligible to vote
        if (age >= 18)
        {
            Console.WriteLine("The person's age is " + age + " and can vote.");
        }
        else
        {
            Console.WriteLine("The person's age is " + age + " and cannot vote.");
        }
    }
}
