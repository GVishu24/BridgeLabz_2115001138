using System;
using System.Collections.Generic;

// Abstract base class for warehouse items
abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    protected WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}

// Derived classes for different item types
class Electronics : WarehouseItem
{
    public string Brand { get; set; }

    public Electronics(string name, double price, string brand)
        : base(name, price)
    {
        Brand = brand;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Electronics: {Name}, Brand: {Brand}, Price: ${Price}");
    }
}

class Groceries : WarehouseItem
{
    public string ExpiryDate { get; set; }

    public Groceries(string name, double price, string expiryDate)
        : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Groceries: {Name}, Expiry: {ExpiryDate}, Price: ${Price}");
    }
}

class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material)
        : base(name, price)
    {
        Material = material;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Furniture: {Name}, Material: {Material}, Price: ${Price}");
    }
}

// Generic storage class with constraint
class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item) => items.Add(item);

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create storage instances for different item types
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();

        // Add items to storage
        electronicsStorage.AddItem(new Electronics("Laptop", 1200, "Dell"));
        electronicsStorage.AddItem(new Electronics("Smartphone", 800, "Samsung"));

        groceriesStorage.AddItem(new Groceries("Milk", 2.5, "2025-03-10"));
        groceriesStorage.AddItem(new Groceries("Bread", 1.5, "2025-02-20"));

        furnitureStorage.AddItem(new Furniture("Chair", 150, "Wood"));
        furnitureStorage.AddItem(new Furniture("Table", 300, "Metal"));

        // Display stored items
        Console.WriteLine("\n--- Electronics Storage ---");
        electronicsStorage.DisplayItems();

        Console.WriteLine("\n--- Groceries Storage ---");
        groceriesStorage.DisplayItems();

        Console.WriteLine("\n--- Furniture Storage ---");
        furnitureStorage.DisplayItems();
    }
}

