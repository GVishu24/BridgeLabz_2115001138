using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "largefile.txt"; // Make sure this file exists

        Console.WriteLine("Starting Large File Reading Test...");

        // Test StreamReader (Reads character by character)
        Stopwatch sw = Stopwatch.StartNew();
        using (StreamReader sr = new StreamReader(filePath))
        {
            while (sr.Read() != -1) { } // Read character by character
        }
        sw.Stop();
        Console.WriteLine($"StreamReader Time: {sw.ElapsedMilliseconds} ms");

        // Test FileStream (Reads bytes directly)
        sw.Restart();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096]; // Read in chunks
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        sw.Stop();
        Console.WriteLine($"FileStream Time: {sw.ElapsedMilliseconds} ms");

        Console.WriteLine("Test Completed.");
    }
}