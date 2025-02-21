using System;

class Nested
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter an index: ");
            int index = int.Parse(Console.ReadLine());

            try
            {
                Console.Write("Enter a divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                int result = numbers[index] / divisor;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter integers only.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
