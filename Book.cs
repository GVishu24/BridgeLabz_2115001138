using System;
class Book
{
    // Instance variables
    private string title;
    private string author;
    private double price;

    // Default constructor
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        price = 0.0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Price: ${price:F2}");
    }
}

// Testing the implementation
class Program
{
    static void Main()
    {
        // Using default constructor
        Book book1 = new Book();
        book1.DisplayBookDetails();

        // Using parameterized constructor
        Book book2 = new Book("The Alchemist", "Paulo Coelho", 18.99);
        book2.DisplayBookDetails();
    }
}