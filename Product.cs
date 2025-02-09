using System;

class Product
{
    // Static variable shared across all products
    private static double Discount = 0.0;
    
    // Readonly variable
    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor using 'this' to resolve ambiguity
    public Product(int ProductID, string ProductName, double Price, int Quantity)
    {
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
    }

    // Static method to update discount
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine($"Discount updated to: {Discount}%");
    }

    // Method to display product details
    public void DisplayProductInfo()
    {
        if (this is Product)  // Using 'is' operator
        {
            Console.WriteLine("=== Product Details ===");
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Discount: {Discount}%");
        }
    }
}

class Program
{
    static void Main()
    {
        // Update discount
        Product.UpdateDiscount(10.0);

        // Creating product objects
        Product prod1 = new Product(101, "Laptop", 110050, 2);
        Product prod2 = new Product(102, "Smartphone", 799.99, 5);
        
        // Display product details
        prod1.DisplayProductInfo();
        prod2.DisplayProductInfo();
    }
}