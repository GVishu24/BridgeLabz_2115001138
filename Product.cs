using System;
class Product
{
    // Instance variables
    private string productName;
    private double price;

    // Class variable (shared among all instances)
    private static int totalProducts = 0;

    // Constructor
    public Product(string name, double price)
    {
        this.productName = name;
        this.price = price;
        totalProducts++;  // Increment totalProducts whenever a new Product is created
    }

    // Instance method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name: {productName}, Price: ${price:F2}");
    }

    // Class method to display total products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products Created: {totalProducts}");
    }
}

// Testing the implementation
class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 1400.50);
        Product p2 = new Product("Smartphone", 800.75);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();

        Product.DisplayTotalProducts();  // Accessing static method
    }
}