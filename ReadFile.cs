using System;
using System.IO;

class FileRead
{
    static void Main()
    {
        string filePath = "data.txt";

        try
        {
            if (!File.Exists(filePath))
            {
                throw new IOException("File not found");
            }

            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:\n" + content);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
