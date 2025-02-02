using System;

public class StudentVoteChecker
{
    // Method to check if the student can vote based on their age
    public bool CanStudentVote(int age)
    {
        // Validate if the age is a negative number
        if (age < 0)
        {
            return false; // Invalid age, cannot vote
        }

        if (age >= 18)
        {
            return true; 
        }

        return false; 
    }
}

class Program
{
    static void Main()
    {
        // Create an array to store the ages of 10 students
        int[] ages = new int[10];

        // Create an instance of StudentVoteChecker class
        StudentVoteChecker checker = new StudentVoteChecker();

        // Loop through the array to take user input for each student's age
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter the age of student " + (i + 1) + ": ");
            int age = Convert.ToInt32(Console.ReadLine());
            ages[i] = age;

            // Call CanStudentVote method and display the result
            if (checker.CanStudentVote(age))
            {
                Console.WriteLine("Student " + (i + 1) + " is eligible to vote.");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " is not eligible to vote.");
            }
        }
    }
}
