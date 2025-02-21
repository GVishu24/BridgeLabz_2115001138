using System;

class Methods
{
    static void Method1()
    {
        // This will throw an ArithmeticException (division by zero)
        int result = 10 / 0;
    }

    static void Method2()
    {
        // Call Method1, allowing the exception to propagate
        Method1();
    }

    static void Main()
    {
        try
        {
            // Call Method2, which will propagate the exception
            Method2();
        }
        catch (ArithmeticException)
        {
            // Handle the exception here
            Console.WriteLine("Handled exception in Main");
        }
    }
}
