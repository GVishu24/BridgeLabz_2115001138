using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("General Person");
        }
    }

    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Teacher - Subject: {Subject}");
        }
    }

    class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Student - Grade: {Grade}");
        }
    }

    class Staff : Person
    {
        public string Position { get; set; }

        public Staff(string name, int age, string position) : base(name, age)
        {
            Position = position;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Staff - Position: {Position}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person teacher = new Teacher("Alice", 35, "Mathematics");
            Person student = new Student("Bob", 16, 10);
            Person staff = new Staff("Charlie", 40, "Administrator");

            teacher.DisplayRole();
            student.DisplayRole();
            staff.DisplayRole();
        }
    }
}

