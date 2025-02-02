using System;

public class StudentScorecard
{
    // Method to generate random scores for Physics, Chemistry, and Math for all students
    public static int[,] GenerateScores(int numberOfStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numberOfStudents, 3];

        for (int i = 0; i < numberOfStudents; i++)
        {
            scores[i, 0] = random.Next(40, 100); // Physics
            scores[i, 1] = random.Next(40, 100); // Chemistry
            scores[i, 2] = random.Next(40, 100); // Math
        }
        return scores;
    }

    // Method to calculate the total, average, and percentage for each student
    public static double[,] CalculateScores(int[,] pcmScores)
    {
        int numberOfStudents = pcmScores.GetLength(0);
        double[,] result = new double[numberOfStudents, 3];

        for (int i = 0; i < numberOfStudents; i++)
        {
            int total = pcmScores[i, 0] + pcmScores[i, 1] + pcmScores[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            result[i, 0] = total;
            result[i, 1] = Math.Round(average, 2);
            result[i, 2] = Math.Round(percentage, 2);
        }
        return result;
    }

    // Method to display the scorecard
    public static void DisplayScorecard(int[,] pcmScores, double[,] calculatedScores)
    {
        Console.WriteLine("\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage\tGrade\tRemarks");

        for (int i = 0; i < pcmScores.GetLength(0); i++)
        {
            int physics = pcmScores[i, 0];
            int chemistry = pcmScores[i, 1];
            int math = pcmScores[i, 2];
            int total = (int)calculatedScores[i, 0];
            double average = calculatedScores[i, 1];
            double percentage = calculatedScores[i, 2];

            string grade;
            string remarks;

            if (percentage >= 80)
            {
                grade = "A";
                remarks = "Level 4, above standards";
            }
            else if (percentage >= 70)
            {
                grade = "B";
                remarks = "Level 3, at standards";
            }
            else if (percentage >= 60)
            {
                grade = "C";
                remarks = "Level 2, approaching standards";
            }
            else if (percentage >= 50)
            {
                grade = "D";
                remarks = "Level 1, below standards";
            }
            else if (percentage >= 40)
            {
                grade = "E";
                remarks = "Level 1-, too below standards";
            }
            else
            {
                grade = "R";
                remarks = "Remedial standards";
            }

            Console.WriteLine($"Student {i + 1}\t{physics}\t\t{chemistry}\t\t{math}\t\t{total}\t\t{average}\t\t{percentage}\t\t{grade}\t{remarks}");
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Generate scores for students
        int[,] pcmScores = GenerateScores(numberOfStudents);

        // Calculate total, average, and percentage for each student
        double[,] calculatedScores = CalculateScores(pcmScores);

        // Display the scorecard
        DisplayScorecard(pcmScores, calculatedScores);
    }
}
