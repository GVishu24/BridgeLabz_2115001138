using System;
using System.Text;
class RemoveDuplicate
{
    static void Main(string[] args)
    {
        Console.Write("Enter A string: ");
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < sb.Length; j++)
            {
                if (sb[j] == input[i])
                {
                    isDuplicate = true;
                    break;

                }
            }
            if (!isDuplicate)
            {
                sb.Append(input[i]);
            }
        }
        Console.WriteLine(sb);
    }


}