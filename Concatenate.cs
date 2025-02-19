using System;
using System.Text;
class Concatenate
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string to concatenate");

        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
                break;

            sb.Append(input).Append(" ");

        }
        Console.Write("concatenated string: ");
        Console.WriteLine(sb.ToString());
    }

}