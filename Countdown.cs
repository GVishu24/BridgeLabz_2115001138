using System;
class Contdown
{
    static void Main(string[] args)
    {
        // Create the counter variable
		Console.WriteLine("Enter countdown value ");
        int counter = int.Parse(Console.ReadLine());

        // Print the counter
        while (counter >= 1)
        {
			Console.WriteLine(counter);
            counter--;
            
        }
		Console.WriteLine("Rocket Launched!!");
    }
}
