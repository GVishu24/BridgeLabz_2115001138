using System;
using System.Collections.Generic;

public enum BookCategory { Fiction, NonFiction, Science, History }
public enum ClothingCategory { Men, Women, Kids }

// Generic Product Class with Type Constraint
public class Product<TCategory>
{
    public string Name { get; set; }
    public double Price { get; set; }
    public TCategory Category { get; set; }

    public Product(string name, double price, TCategory category)
    {
        Name = name;
        Price = price;
        Category = category;
    }
}

// Generic Catalog Class
public class ProductCatalog
{
    private List<object> _products = new List<object>();

    public void AddProduct<TCategory>(Product<TCategory> product)
    {
        _products.Add(product);
    }

    public void DisplayProducts()
    {
        foreach (var product in _products)
        {
            Console.WriteLine(product);
        }
    }
}

// Generic Discount Method
public static class DiscountHelper
{
    public static void ApplyDiscount<TCategory>(Product<TCategory> product, double percentage)
    {
        if (percentage < 0 || percentage > 100)
        {
            throw new ArgumentException("Percentage should be between 0 and 100");
        }
        product.Price -= product.Price * (percentage / 100);
    }
}

// Testing the Implementation
public class Program
{
    public static void Main()
    {
        Product<BookCategory> book = new Product<BookCategory>("C# Programming", 50.0, BookCategory.Science);
        Product<ClothingCategory> shirt = new Product<ClothingCategory>("Men's T-Shirt", 20.0, ClothingCategory.Men);

        Console.WriteLine($"Before Discount: {book.Name} - ${book.Price}");
        DiscountHelper.ApplyDiscount(book, 10);
        Console.WriteLine($"After Discount: {book.Name} - ${book.Price}");

        ProductCatalog catalog = new ProductCatalog();
        catalog.AddProduct(book);
        catalog.AddProduct(shirt);
    }
}
