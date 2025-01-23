using System;
class MultiplicationTable
{
    static void Main()
    {
        // Input from user
        Console.WriteLine("Enter a number to find its multiplication table from 6 to 9:");
        int number = int.Parse(Console.ReadLine());

        // print the multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
