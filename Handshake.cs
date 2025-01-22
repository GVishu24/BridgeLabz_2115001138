using System;

class Handshake
{
    // Function to calculate the maximum number of handshakes
    static int CalculateHandshakes(int numberOfStudents)
    {
        // Use the combination formula to calculate the maximum number of handshakes
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }

    static void Main(string[] args)
    {
        // user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Call the function to calculate the maximum number of handshakes
        int handshakes = CalculateHandshakes(numberOfStudents);

        // Display 
        Console.WriteLine("The maximum number of possible handshakes among " + numberOfStudents + " students is " + handshakes);
    }
}
