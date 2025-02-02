using System;  
class Program  
{  
    static void Main(string[] args)  
    {  
        // Take input from the user  
        Console.Write("Enter your name and favorite quote: ");  
        string name = Console.ReadLine();  
        Console.WriteLine(name + " said, \"" + Console.ReadLine()?.Trim() + "\"");  
    }  
}
