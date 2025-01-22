using System;

class Program
{
    // Function to calculate the discount and final fee
    static void CalculateDiscount(double fee, double discountPercent)
    {        
        double discount = (discountPercent / 100) * fee;
        double finalFee = fee - discount;

        // display
        Console.WriteLine(string.Format("The discount amount is INR {0} and the final discounted fee is INR {1}.", discount, finalFee));
    }

    static void Main(string[] args)
    {
        // Take user input for fee
        Console.Write("Enter the total fee (INR): ");
        double fee = Convert.ToDouble(Console.ReadLine());

        // Take user input for discount percentage
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Call the function 
        CalculateDiscount(fee, discountPercent);
    }
}
