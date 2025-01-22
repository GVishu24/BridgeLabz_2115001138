using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize variables
        double fee = 125000; 
        double discountPercent = 10;  

        // Calculate the discount amount
        double discount = (discountPercent / 100) * fee;

        // Calculate the final fee after the discount
        double finalFee = fee - discount;

        // Display
        Console.WriteLine(string.Format("The discount amount is INR {0} and the final discounted fee is INR {1}.",discount,finalFee));
    }
}
