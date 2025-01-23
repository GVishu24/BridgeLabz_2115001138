using System;

class RocketLaunch
{
    static void Main()
    {
        // input countdown value
        Console.WriteLine("Enter the countdown start value:");
        int counter = int.Parse(Console.ReadLine());

        // printing Countdown using for loop 
        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i); 
        }
        Console.WriteLine("Rocket launched!!!");
    }
}