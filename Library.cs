using System;


namespace Inheritance
{
    class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
        }
    }

    class Author : Book
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author: {Name}, Bio: {Bio}");
        }
    }

    class Program
    {
        static void Main()
        {
            Author author = new Author("The Great Novel", 2020, "Robert Frost", "A renowned writer of fiction.");
            author.DisplayInfo();
        }
    }
}


