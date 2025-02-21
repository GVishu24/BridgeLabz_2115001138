using System;
class IndexOutOfRange
{
    static void RetrieveValue(int[] array, int index)
    {
        try
        {
            if (array == null)
            {
                throw new NullReferenceException("Array is not initialized!");
            }

            Console.WriteLine($"Value at index {index}: {array[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the index to retrieve: ");
            int index = int.Parse(Console.ReadLine());

            RetrieveValue(array, index);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
        }
    }
}
