using System;

class Book
{
    // Static variable shared across all books
    private static string LibraryName = "City Library";
    
    // Readonly variable
    public readonly string ISBN;
    public string Title;
    public string Author;

    // Constructor using 'this' to resolve ambiguity
    public Book(string Title, string Author, string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }

    // Static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine($"Library Name: {LibraryName}");
    }

    // Method to display book details
    public void DisplayBookInfo()
    {
        if (this is Book)  // Using 'is' operator
        {
            Console.WriteLine("=== Book Details ===");
            Console.WriteLine($"Library: {LibraryName}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Display library name
        Book.DisplayLibraryName();

        // Creating book objects
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "978-0061120084");
        
        // Display book details
        book1.DisplayBookInfo();
        book2.DisplayBookInfo();
    }
}
