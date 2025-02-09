using System;
using System.Collections.Generic;

// Course Class (Association)
class Course
{
    public string CourseName { get; }
    private List<Student> students;

    public Course(string name)
    {
        CourseName = name;
        students = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        students.Add(student);
    }

    public void ShowEnrolledStudents()
    {
        Console.WriteLine($"Course: {CourseName} - Enrolled Students:");
        foreach (var student in students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}

// Student Class (Aggregation with School, Association with Course)
class Student
{
    public string Name { get; }
    private List<Course> courses;

    public Student(string name)
    {
        Name = name;
        courses = new List<Course>();
    }

    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
        course.EnrollStudent(this); // Bidirectional association
    }

    public void ShowCourses()
    {
        Console.WriteLine($"{Name} is enrolled in:");
        foreach (var course in courses)
        {
            Console.WriteLine($"- {course.CourseName}");
        }
    }
}

// School Class (Aggregation)
class School
{
    public string SchoolName { get; }
    private List<Student> students;

    public School(string name)
    {
        SchoolName = name;
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void ShowStudents()
    {
        Console.WriteLine($"School: {SchoolName} - Students:");
        foreach (var student in students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}

// Program Execution
class Program
{
    static void Main()
    {
        // Create School
        School school = new School("Greenwood High");

        // Create Students
        Student alice = new Student("Alice");
        Student bob = new Student("Bob");

        // Add students to the school (Aggregation)
        school.AddStudent(alice);
        school.AddStudent(bob);

        // Create Courses
        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        // Enroll students in courses (Many-to-Many Association)
        alice.EnrollInCourse(math);
        alice.EnrollInCourse(science);
        bob.EnrollInCourse(science);

        // Display School Students
        school.ShowStudents();
        
        // Show Courses per Student
        alice.ShowCourses();
        bob.ShowCourses();

        // Show Students per Course
        math.ShowEnrolledStudents();
        science.ShowEnrolledStudents();
    }
}