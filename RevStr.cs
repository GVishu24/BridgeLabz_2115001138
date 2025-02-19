using System;
using System.Text;


class RevStr
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        StringBuilder sb = new StringBuilder("Hello");
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);

        }
        Console.WriteLine(sb.ToString());

    }
}
