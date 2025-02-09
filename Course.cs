using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Course
    {
        public string CourseName { get; set; }
        public int Duration { get; set; } // Duration in weeks

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
        }
    }

    class OnlineCourse : Course
    {
        public string Platform { get; set; }
        public bool IsRecorded { get; set; }

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
            : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Platform: {Platform}, Recorded: {IsRecorded}");
        }
    }

    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee { get; set; }
        public double Discount { get; set; }

        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fee: ${Fee}, Discount: {Discount}%");
        }
    }

    class Program
    {
        static void Main()
        {
            Course basicCourse = new Course("Introduction to Programming", 6);
            OnlineCourse onlineCourse = new OnlineCourse("Web Development", 8, "Udemy", true);
            PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced Machine Learning", 12, "Coursera", true, 199.99, 20);

            basicCourse.DisplayInfo();
            Console.WriteLine();
            onlineCourse.DisplayInfo();
            Console.WriteLine();
            paidCourse.DisplayInfo();
        }
    }
}