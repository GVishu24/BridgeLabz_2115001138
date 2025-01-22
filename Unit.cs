using System;

class Unit
{
    // Function to calculate the total price
    static double CalculateTotalPrice(double unitPrice, int quantity)
    {
        return unitPrice * quantity;
    }

    static void Main(string[] args)
    {
        // Take user input for the unit price and quantity
        Console.Write("Enter the unit price of the item: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Call the function to calculate the total price
        double totalPrice = CalculateTotalPrice(unitPrice, quantity);

        // Display the result
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and unit price is INR " + unitPrice);
    }
}
