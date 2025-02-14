using System;
class InsertionSort
{
    static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 105, 106, 102, 201, 205, 200 };
            Sort(arr);
            Console.Write("sorted Id's: ");
            foreach (int k in arr)
            {
                Console.Write(k+ " ");
            }
        }
    }
}

