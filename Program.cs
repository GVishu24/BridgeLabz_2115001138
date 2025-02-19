////using System;

////class FibonacciRecursion
////{
////    static int Fibonacci(int n)
////    {
////        if (n <= 0) return 0;  // Base case: Fibonacci(0) = 0
////        if (n == 1) return 1;  // Base case: Fibonacci(1) = 1

////        return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive formula
////    }

////    static void Main()
////    {
////        Console.Write("Enter the number of terms: ");
////        int terms = Convert.ToInt32(Console.ReadLine());

////        Console.WriteLine("Fibonacci Series:");
////        for (int i = 0; i < terms; i++)
////        {
////            Console.Write(Fibonacci(i) + " ");
////        }
////    }
////}


//using System;

//class FibonacciRecursion
//{
//    static int Fibonacci(int n)
//    {
//        if (n <= 0) return 0;  // Base case: Fibonacci(0) = 0
//        if (n == 1) return 1;  // Base case: Fibonacci(1) = 1

//        return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive formula
//    }

//    static void Main()
//    {
//        Console.Write("Enter the value of N: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        int result = Fibonacci(n);
//        Console.WriteLine($"The {n}th Fibonacci number is: {result}");
//    }
//}
