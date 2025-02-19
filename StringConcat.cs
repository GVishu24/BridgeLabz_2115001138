using System;
using System.Diagnostics;
using System.Text;
class SortingComp
{
    static void Main(string[] args)
    {
        int n = 100000;
        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();
        string str = "";
        for (int i =0; i < n; i++)
        {
            str += " a";
        }
        sw.Stop();
        //Console.WriteLine(str);
        Console.WriteLine($"String concatenation time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(" a");
        }
        sw.Stop();
        //Console.WriteLine(sb.ToString());
        Console.WriteLine($"StringBuilder concatenation time: {sw.ElapsedMilliseconds} ms");
    }
}
