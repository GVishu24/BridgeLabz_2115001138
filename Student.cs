using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Student
    {
        public int RollNo;
        public string Name;
        public int Age;
        public string Grade;
        public Student Next;

        public Student(int rollNo, string name, int age, string grade)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }
    class StudentList
    {
        private Student head;

        public void AddStudentAtBegin(int rollNo, string name, int age, string grade)
        {
            Student newStudent = new Student(rollNo, name, age, grade);
            newStudent.Next = head;
            head = newStudent;
        }

        public void AddStudentAtEnd(int rollNo, string name, int age, string grade)
        {
            Student newStudent = new Student(rollNo, name, age, grade);
            if (head == null)
            {
                head = newStudent;
                return;
            }
            Student temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;

        }
        public void AddStudentAtPos(int rollNo, string name, int age, string grade, int pos)
        {
            Student temp = head;
            int curr = 1;
            if (pos < 1)
            {
                Console.WriteLine("enter valid position");
            }


            if (pos == 1)
            {

                AddStudentAtBegin(rollNo, name, age, grade);
                return;
            }
            while (curr < pos - 1)
            {
                temp = temp.Next;
                curr++;

            }
            Student newNode = new Student(rollNo, name, age, grade);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
        public void DelStudentByRoll(int key)
        {
            Student temp = head;
            if (temp != null && temp.RollNo == key)
            {
                head = temp.Next;
                return;
            }
            while (temp != null)
            {
                if (temp.Next.RollNo == key)
                {
                    temp.Next = temp.Next.Next;
                    return;
                }
                temp = temp.Next;
            }
        }
        public Student SearchStudentByRollNumber(int rollNumber)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNo == rollNumber)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }
        public void DisplayAllStudents()
        {
            Student temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Roll No: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                temp = temp.Next;
            }
        }
        public void UpdateStudentGrade(int rollNumber, string newGrade)
        {
            Student student = SearchStudentByRollNumber(rollNumber);
            if (student != null)
            {
                student.Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            StudentList sl = new StudentList();

            sl.AddStudentAtEnd(3, "Lakshay", 22, "B");
            sl.AddStudentAtBegin(1, "Vishu", 23, "B");
            sl.AddStudentAtEnd(4, "Vedant", 20, "C");
            sl.AddStudentAtPos(2, "Shrey", 23, "A", 2);

            Console.WriteLine("All students data:");

            sl.DisplayAllStudents();

            Console.WriteLine("\nSearching for Student with Roll No 2:");
            Student found = sl.SearchStudentByRollNumber(2);
            if (found != null)
                Console.WriteLine($"Found - Roll No: {found.RollNo}, Name: {found.Name}, Age: {found.Age}, Grade: {found.Grade}");
            else
                Console.WriteLine("Student not found!");

            Console.WriteLine("\nUpdating Grade of Roll No 1 to A+");
            sl.UpdateStudentGrade(1, "A+");

            Console.WriteLine("\nAll Student Records After Update:");
            sl.DisplayAllStudents();

            Console.WriteLine("\nDeleting Student with Roll No 3");
            sl.DelStudentByRoll(3);

            Console.WriteLine("\nAll Student Records After Deletion:");
            sl.DisplayAllStudents();
        }
    }
}
    

            
        



