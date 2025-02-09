using System;

class Student
{
    // Static variable shared across all students
    private static string UniversityName = "Global University";
    private static int totalStudents = 0;
    
    // Readonly variable
    public readonly int RollNumber;
    public string Name;
    public string Grade;

    public Student(string Name, int RollNumber, string Grade)
    {
        this.Name = Name;
        this.RollNumber = RollNumber;
        this.Grade = Grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine($"Total Students Enrolled: {totalStudents}");
    }

    // Method to display student details
    public void DisplayStudentInfo()
    {
        if (this is Student) 
        {
            Console.WriteLine("=== Student Details ===");
            Console.WriteLine($"University: {UniversityName}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Alice Brown", 101, "A");
        Student student2 = new Student("Bob White", 102, "B");
        
        student1.DisplayStudentInfo();
        student2.DisplayStudentInfo();
        
        Student.DisplayTotalStudents();
    }
}